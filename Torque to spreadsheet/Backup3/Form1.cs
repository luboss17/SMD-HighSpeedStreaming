using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public bool newdata = false;
        public bool aquire = false;
        public bool formActive = true;
        public int rowCount = 1;
        public string tester_Type = "No Tester";
        public BindingList <bool> dataColumns = new BindingList<bool>();
        public ArrayList checkboxes = new ArrayList();
        public static string serialData = "";
        public bool beep = true;
        public bool comCheck = false;
       

        public Form1()
        {
            InitializeComponent();
           
        }

        
      

        private void Form1_Load(object sender, EventArgs e)
        {
            loadSettings();
            loadPorts();
            try
            {
                serialPort1.PortName = toolStripDropDownButton1.DropDownItems[0].Text; //sets port name to first item in list as default
            }
            catch
            {
                toolStripStatusLabel2.Text = " Status: Warning! No Serial Ports detected!"; //displays when no serial ports are present
            }

           

            foreach(ToolStripItem s in toolStripDropDownButton1.DropDownItems)
            {
                if(s.Text==Properties.Settings.Default.Com_Port_setting) //search list of avaliable ports for the previously saved port
                    {
                     serialPort1.PortName=s.Text; //set port name to previously saved port, if found
                    }

            }

                toolStripStatusLabel1.Text = "Port: " + serialPort1.PortName; //set port label to current port

                if (autoConnectToolStripMenuItem.Checked)
                {
                    Button_Serial_Click(this,e);
                }
                if (Properties.Settings.Default.Spreadsheet_mode)
                {
                    Button_Aquire_Click(this,e);
                }

                if (Properties.Settings.Default.Start_Minimized && Properties.Settings.Default.Spreadsheet_mode) //if start minimized and spreadsheet mode are active, minimize at startup
                {
                    
                    this.WindowState = FormWindowState.Minimized;
                   // notifyIcon.Visible = true;
                    
                }

                checkboxes.Add(checkBox1);
                checkboxes.Add(checkBox2);
                checkboxes.Add(checkBox3);
                checkboxes.Add(checkBox4);
                checkboxes.Add(checkBox5);
           
          
           
        }

        private void Button_Serial_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                toolStripStatusLabel2.Text = " Status: Closed";
            }
            else
            {
                try
                {
                    serialPort1.Open();
                    serialPort1.Write("?S;");
                    comCheck = true;
                    toolStripStatusLabel2.Text = " Status: Open";
                    backgroundWorker1.RunWorkerAsync(); //run background worker
                }
                catch { toolStripStatusLabel2.Text = " Status: Error Opening Port!"; }
            
            }
        }

        private void Button_Aquire_Click(object sender, EventArgs e) //user clicks the activate spreadsheet transfer button
        {
            if (aquire)
            {
                aquire = false;
                Button_Aquire.Text = "Activate Spreadsheet Transfer";
                SpreadSheetModeLabel.Text = "Deactivated";
                Properties.Settings.Default.Spreadsheet_mode = false;
            }
            else
            {
            aquire = true;
            Button_Aquire.Text = "Stop Spreadsheet Transfer";
                SpreadSheetModeLabel.Text="Activated";
                Properties.Settings.Default.Spreadsheet_mode = true;
            }
        }

        private void process_data() //displays data and sends it as keyboard input
        {
          
                newdata = false;
                try
                {
                    string[] data = parseData(serialData); //parse the serial data
                    serialData = ""; //reset the variable


                    if (enableSoundsToolStripMenuItem.Checked && beep==true)
                    {
                       // System.Media.SystemSounds.Asterisk.Play();
                        System.Console.Beep(800, 70);
                        System.Console.Beep(1000, 50);
                        System.Console.Beep(2000, 50);

                        beep = false;
                    }

                    

                    if (tester_Type == "Millivolt Tester" && checkBox_millivolt.Checked)
                    {
                        string[] data2= new string[2]{data[2],data[3]};
                        data = data2;
                        
                    }

                    if (tester_Type == "Standard QC no memory" || tester_Type == "Standard Mini no memory") //if we have have a QC or a mini, assume they are torque and units and display them using separate labels
                    { Label_Data.Text = data[0];
                        Label_Units.Text = data[1];
                        Label_Units.Visible = true;
                    }
                    else
                    {
                        Label_Data.Text = ""; //if we don't have a standard qc or a mini, just display all the data in one label
                        foreach (string s in data)
                        {
                            Label_Data.Text = Label_Data.Text + " " + s;
                        }
                        Label_Units.Visible = false; }
               

                    if(aquire && formActive==false)
                    {

                        if (data.Length == 1 &&data[0].Length>2)//if data was dumped to one line, but it is more than 2 character
                        {
                          // data[0] = data[0].Substring(0, data[0].Length - 1); //strips newline characters. actually strips last char no matter what *** fix this
                        }


                        for(int i=0;i<data.Length;i++) //for each string in data
                        {
                            if (data[i][0] == '-' || data[i][0] == '+' || data[i][0] == '=') //if the first char in any cell is a negative, plus, or equals sign, excel freaks out
                            {
                                data[i] = " " + data[i]; //this adds a space before the data value if the first char is a neg or plus sign, to prevent excel from thinking its a formula
                            }

                           // if (data[i][0] == '+') //if the first char in any cell is a plus sign, excel freaks out AND sendkeys freaks out
                           // {
                            //    data[i] = " +" + data[i].Substring(1,data[i].Length-1); //this adds a space before the data value if the first char is a neg or plus sign, to prevent excel from thinking its a formula
                          //  }

                        
                        }


                        string[] stampformats = new string[] { "d", "T", "G" };
                        int stamp = Convert.ToInt16(includeDateToolStripMenuItem.Checked)*1 + Convert.ToInt16(includeTimeToolStripMenuItem.Checked) * 2;

                        DateTime dt = DateTime.Now;

                        if (Reading_Only_Box.Checked) //if we only want units, we may still want timestamp
                        {

                            if (stamp > 0) //if we want timestamp, add it and the units to a re-initialized data array
                            {
                                data = new string[] { dt.ToString(stampformats[stamp - 1]), data[0] };
                            }
                            else
                            {
                                data = new string[] { data[0] }; //or just add the data
                            }

                        }
                        else if (Reading_Only_Box.Checked==false && stamp > 0) //keep all the current data and add a time stamp
                        {
                            string[] data_temp = data; //store data in a new array
                                                     
                            data = new string[data.Length+1]; //re-initialize data one larger

                            data[0] = (dt.ToString(stampformats[stamp - 1])); //insert time stamp as the first value

                            for (int i = 0; i < data_temp.Length; i++)
                            {
                                data[i+1] = data_temp[i]; //put old data back into data
                            }

                        }

                       
                        
                            foreach (string s in data) //escape all characters that need it
                            {
                                string temp;
                                temp=s.Replace("+", "{+}");
                                temp=temp.Replace("%", "{%}");
                                temp = temp.Replace("~", "{~}");
                                temp = temp.Replace("(", "{(}");
                                temp = temp.Replace(")", "{)}");
                                temp = temp.Replace("^", "{^}");//sendkeys can't do these characters without this

                                SendKeys.Send(temp); //Send the data

                                if (s != data[data.Length-1]) //if it is not the last item to send
                                { SendKeys.Send("{TAB}"); } //then send a tab to move over one cell
                               
                            }

                

                        if(rowCount<RowCountMax.Value)  //after the last item is sent (above) check if we are doing
                        {                               //multiple items per row, and send a tab if we are not at
                            SendKeys.Send("{TAB}");     //the last item
                            rowCount++;

                        }else
                        {
                            SendKeys.Send("{ENTER}");   //or send an <Enter> if we are at the last item
                            rowCount = 1;

                        }
                    }
                }
                catch (System.Exception excep) { MessageBox.Show(excep.Message); }

               if(serialPort1.IsOpen) backgroundWorker1.RunWorkerAsync(); //run the backgroundworker again if the serial port hasn't been closed
            
        }

        private void toolStripDropDownButton1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Port: " + e.ClickedItem.Text;
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                serialPort1.PortName = e.ClickedItem.Text;
                try
                {
                    serialPort1.Open();
                     }
                catch { toolStripStatusLabel2.Text = " Status: Error Opening Port!"; }

            }
            else
            {
                serialPort1.Open();
                /*serialPort1.PortName = e.ClickedItem.Text;
                serialPort1.Write("?S;");
                comCheck = true;
                backgroundWorker1.RunWorkerAsync();
                //*****************************************************************/
            }

            Properties.Settings.Default.Com_Port_setting = serialPort1.PortName; //save port name to user settings
        }

        private void toolStripDropDownButton1_MouseHover(object sender, EventArgs e)
        {
            loadPorts();
            toolStripDropDownButton1.ShowDropDown();
           
        }

        private void toolStripStatusLabel1_MouseHover(object sender, EventArgs e)
        {
            loadPorts();
            toolStripDropDownButton1.ShowDropDown();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AboutMe = new AboutBox1();
            AboutMe.ShowDialog(this);           
            AboutMe.Dispose();

           
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            formActive = true;
          
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            formActive = false;
          
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (RowCountMax.Value == 0)
            {
                RowCountMax.Value = 1;
            }
            Properties.Settings.Default.rowcountmax = RowCountMax.Value;
            rowCount = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rowCount = 1; //reset row counter
        }

        private string[] parseData(string data)   //parses the data *** needs to be rewritten for regex!
        {
            string[] dataArray;

            Console.WriteLine(data);
            
            string[,] regex_strings = new string[,] {
            {"QC",  @"(^(?=.{12}\r)(?:\s|-)\d{1,5}\.?\d{0,4})\s(\w{1,5})\s{0,3}\r", "Reading,Units" },
            {"Mini",@"(^(?=.{13}\r)(?:\s|-)\d{1,5}\.?\d{0,4})\s(\w{1,5})\s{1,4}\r","Reading,Units"},
            {"Mini Streaming",@"^(?=.{15,16}\r)(\d{1,3}\.?\d{0,5})\s(-?\d{1,5}\.?\d{0,5})","Time,Sample"},
            {"Mini Streaming",@"^(Time):\s(Sample)","Time,Sample"},
            {"Mini with Memory", @"^(?=.{17}\r)(\d{0,3})\s((?:\s|-)\d{1,5}\.?\d{0,4})\s(\w{1,5})","Memory Location,Reading,Units"},
           
            
            {"Other",@"(^.+)\r","Other"}, //these two should be last, as they match pretty much everything
            {"New Line",@"(^\r)","New Line"}  
        };

            for (int i = 0; i < regex_strings.Length / 3; i++)
            {
                string query_string = regex_strings[i, 1];
                
                    Match matches = Regex.Match(data, query_string);
                    GroupCollection group = matches.Groups;
                    if (group.Count > 1)
                    {
                    dataArray = new string[group.Count-1];
                                       
                    for (int j = 1; j < group.Count; j++)
                    {
                        dataArray[j-1] = group[j].ToString();
                    }
                    string product = regex_strings[i, 0];
                     
                        return dataArray;
                    }
               
                
            }


            
                switch (data.Length)
                {

                    /**/
                    case 18: //4050 With Memory
                        tester_Type = "4050 With Memory";
                        Tester_Type_Label.Text = tester_Type;
                        Tester_Type_Label.Visible = false;
                        dataArray = new string[3];
                        dataArray[0] = data.Substring(0, 3);
                        dataArray[1] = data.Substring(4, 6);
                        dataArray[2] = data.Substring(10, 5);
                        break;

                    case 16://4050 streaming                    
                        tester_Type = "4050 streaming";
                        Tester_Type_Label.Text = tester_Type;
                        Tester_Type_Label.Visible = false;
                        dataArray = new string[2];
                        dataArray[0] = data.Substring(0, 7);
                        dataArray[1] = data.Substring(8, 7);
                        break;

                    case 17:
                        tester_Type = "4050 streaming";
                        Tester_Type_Label.Text = tester_Type;
                        Tester_Type_Label.Visible = false;
                        dataArray = new string[2];
                        dataArray[0] = data.Substring(0, 7);
                        dataArray[1] = data.Substring(8, 8);

                        break;

                    case -10: //streaming tester special values
                        dataArray = new string[1];
                        dataArray[0] = data;
                        break;

                    case 13: //Standard QC
                        if (data[0] == 'T' || data[0] == 'U')
                        { goto case -10; }
                        tester_Type = "Standard QC no memory";
                        Tester_Type_Label.Text = tester_Type;
                        Tester_Type_Label.Visible = false;
                        goto case 0;
                    case 14: //Standard Mini Board without memory
                        if (data[0] == 'T' || data[0] == 'U')
                        { goto case -10; }
                        tester_Type = "Standard Mini no memory";
                        Tester_Type_Label.Text = tester_Type;
                        Tester_Type_Label.Visible = false;
                        goto case 0;
                    case 0: //QC or Mini
                        dataArray = new string[2];
                        dataArray[0] = data.Substring(0, 6);
                        dataArray[1] = data.Substring(7, 5);
                        //   string[] column_array = new string[2] { "Reading", "Units" };
                        //   col_select(column_array);
                        break;
                    case 26: //millivolt tester
                        dataArray = new string[4];
                        dataArray[0] = data.Substring(0, 6);
                        dataArray[1] = data.Substring(7, 5);
                        dataArray[2] = data.Substring(12, 8);
                        dataArray[3] = data.Substring(21, 4);
                        tester_Type = "Millivolt Tester";
                        Tester_Type_Label.Text = tester_Type;
                        checkBox_millivolt.Visible = true;
                        Tester_Type_Label.Visible = true;
                        break;
                    default:
                        dataArray = new string[1];
                        dataArray[0] = data.Substring(0, data.Length - 1);
                        //  dataArray[1] = data.Length.ToString(); //COMMENT THIS OUT TO HIDE THE LINE LENGTH don't forget to change the array size
                        break;


                
            }      

            return dataArray;
        }

        private void col_select(string[] s)
        {
            groupBox1.Visible = true;
            int i = 1;
            foreach(string n in s)
            {
           CheckBox txt = (CheckBox) flowLayoutPanel1.Controls["checkBox" + i.ToString()];
           txt.Text = n;
           txt.Enabled = true;
           txt.Visible = true;
             i++;
           }
            while (i <= s.Length)
            {
                try
                {
                    CheckBox txt = (CheckBox)this.Controls["checkBox" + i.ToString()];
                    txt.Enabled = false;
                    txt.Visible = false;
                    txt.Checked = true;

                }
                catch { break; }
                i++;
            }

        
            

        }

        private void enableSoundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Enable_sounds_setting = enableSoundsToolStripMenuItem.Checked;
                        
          
        }

       
        private void loadSettings()
    {
            enableSoundsToolStripMenuItem.Checked=Properties.Settings.Default.Enable_sounds_setting;
            autoConnectToolStripMenuItem.Checked = Properties.Settings.Default.Auto_Connect;
            this.TopMost=alwaysOnTopToolStripMenuItem.Checked = Properties.Settings.Default.ON_Top_Setting;
            includeDateToolStripMenuItem.Checked = Properties.Settings.Default.DateStamp_Setting;
            includeTimeToolStripMenuItem.Checked = Properties.Settings.Default.TimeStamp_Setting;
            RowCountMax.Value = Properties.Settings.Default.rowcountmax;
            Reading_Only_Box.Checked = Properties.Settings.Default.readings_only;
            
            
            if (autoConnectToolStripMenuItem.Checked)
            {
                startMinimizedToolStripMenuItem.Enabled = true;
                startMinimizedToolStripMenuItem.Checked = Properties.Settings.Default.Start_Minimized;
            }

            return;
    }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
            notifyIcon.Dispose();
        }

        private void loadPorts()
    {
        toolStripDropDownButton1.DropDownItems.Clear();


        foreach (string port in System.IO.Ports.SerialPort.GetPortNames())
        {
            toolStripDropDownButton1.DropDownItems.Add(port);   //add each avaliable port to the dropdown list             
        }


    }

        private void autoConnectToolStripMenuItem_Click(object sender, EventArgs e) //if the auto connect option is clicked in the menu strip
        {
            Properties.Settings.Default.Auto_Connect = autoConnectToolStripMenuItem.Checked; //set the persistent setting to the item's checked state
            startMinimizedToolStripMenuItem.Enabled = autoConnectToolStripMenuItem.Checked; //enable the start minimized option if auto connect is checked
         
        }

        private void startMinimizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Start_Minimized = startMinimizedToolStripMenuItem.Checked; //save the start minimized option if it is clicked
        }

        private void startMinimizedToolStripMenuItem_EnabledChanged(object sender, EventArgs e)
        {

            if (startMinimizedToolStripMenuItem.Enabled==false) //if the option was just disabled, reset things
            {
                startMinimizedToolStripMenuItem.Checked = false; //reset the checked state for this session
                Properties.Settings.Default.Start_Minimized = false; //reset the checked state setting 
            }
                
           
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = alwaysOnTopToolStripMenuItem.Checked;
            Properties.Settings.Default.ON_Top_Setting = alwaysOnTopToolStripMenuItem.Checked;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            serialPort1.ReadTimeout = 200;

           try
            {
               if(serialPort1.BytesToRead>0)
                serialData = serialPort1.ReadLine();
               
            }

           catch (System.Exception excep)
           {
               beep = true; //we will only beep again if we have timed out recently, to prevent beeping repeatedly during a large dump
               try
               {
                   serialPort1.ReadExisting(); //clear the port if we don't get a whole line, so we don't send it later
               }
               catch { }
              
           }

          
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (serialData.Length>0)
                if (comCheck==false)
                    { process_data(); }
                else
                    {
                    toolStripTesterType.Text = "Serial Number:"+serialData;
                    comCheck = false;
                    }
            else { backgroundWorker1.RunWorkerAsync(); }
        }

     
        private void includeTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            includeTimeToolStripMenuItem.Checked = (includeTimeToolStripMenuItem.Checked == false);//toggle time stamp            
            Properties.Settings.Default.TimeStamp_Setting = includeTimeToolStripMenuItem.Checked;
        }

        private void includeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            includeDateToolStripMenuItem.Checked = (includeDateToolStripMenuItem.Checked == false);//toggle date stamp            
            Properties.Settings.Default.DateStamp_Setting = includeDateToolStripMenuItem.Checked;

        }

        private void Reading_Only_Box_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.readings_only = Reading_Only_Box.Checked;
        }
        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }


    }
}
