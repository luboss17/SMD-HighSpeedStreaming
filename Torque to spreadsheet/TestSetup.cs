using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Core;

namespace WindowsFormsApplication1
{
    
    public class TestSetup
    {
        public string testID, pointAmount, FullScale, low, high, percent_unit, ch1Unit,ch2Unit,testOrder,testType,defaultTest,sampleNum;
        public DataTable testTable=new DataTable();

        private const string testID_header = "Test ID",
            pointAmount_header = "Point Amount",
            fullScale_header = "Full Scale",
            low_header = "Low",
            high_header = "High",
            percent_unit_header = "% or Unit",
            ch1Unit_header = "Ch1-Unit",
            ch2Unit_header = "Ch2-Unit",
            testTable_header = "TestTable",
            testOrder_header = "Test Order",
            testType_header = "TestType",
            defaultTest_header = "Default",//For precanned test setup, yes=can not change name and max point
            sampleNum_header = "SampleNum";


        private const string point_tableHeader = "#",
            target_tableHeader = "Target",
            low_tableHeader = "Low",
            high_tableHeader = "High",
            order_tableHeader = "Order";
        
        public string get_sampleNumHeader()
        {
            return sampleNum_header;
        }
        public string get_testOrderHeader()
        {
            return testOrder_header;
        }
        public string get_testIDHeader()
        {
            return testID_header;
        }
        
        public string get_defaultTestHeader()
        {
            return defaultTest_header;
        }
        public string get_pointAmount_header()
        {
            return pointAmount_header;
        }

        public string get_testFSHeader()
        {
            return fullScale_header;
        }

        public string get_testlowHeader()
        {
            return low_header;
        }

        public string get_testhighHeader()
        {
            return high_header;
        }

        public string get_percentOrUnitHeader()
        {
            return percent_unit_header;
        }

        public string get_ch1UnitHeader()
        {
            return ch1Unit_header;
        }

        public string get_ch2UnitHeader()
        {
            return ch2Unit_header;
        }

        public string get_testTableHeader()
        {
            return testTable_header;
        }

        public string get_testTypeHeader()
        {
            return testType_header;
        }

        public string get_pointTableHeader()
        {
            return point_tableHeader;
        }

        public string get_targetTableHeader()
        {
            return target_tableHeader;
        }

        public string get_lowTableHeader()
        {
            return low_tableHeader;
        }

        public string get_highTableHeader()
        {
            return high_tableHeader;
        }

        public string get_orderTableHeader()
        {
            return order_tableHeader;
        }
        //Constructor, set all headers to "" and init testTable
        public TestSetup()
        {
            testID = "";
            pointAmount = "";
            FullScale = "";
            low = "";
            high = "";
            percent_unit = "%";
            ch1Unit = "";
            ch2Unit = "";
            testOrder = "";
            testType = "0";
            sampleNum = "1";


            initTestTable();
        }
        
        //init Column name for testTable
        private void initTestTable()
        {
            testTable.Columns.Add(point_tableHeader);
            testTable.Columns.Add(low_tableHeader);
            testTable.Columns.Add(target_tableHeader);
            testTable.Columns.Add(high_tableHeader);
            testTable.Columns.Add(order_tableHeader);
        }

        private bool checkIfAllRowEmpty(DataRow tableRow)
        {
            //return true if all column of this row is empty.
            if ((tableRow[point_tableHeader]=="") && (tableRow[target_tableHeader]=="") && (tableRow[low_tableHeader]=="") && (tableRow[high_tableHeader]=="") && (tableRow[order_tableHeader]==""))
                return true;
            else
                return false;
        }
        //get List of String that has ALL data of this testSetup, used to write to CSV
        public List<string> GetCsvStrList()
        {
            List<string> strToCSV = new List<string>();
            strToCSV.Add(testID_header+","+testID);
            strToCSV.Add(defaultTest_header+","+defaultTest);
            strToCSV.Add(pointAmount_header+","+pointAmount);
            strToCSV.Add(fullScale_header+","+FullScale);
            strToCSV.Add(low_header+","+low);
            strToCSV.Add(high_header+","+high);
            strToCSV.Add(percent_unit_header+","+percent_unit);
            strToCSV.Add(ch1Unit_header+","+ch1Unit);
            strToCSV.Add(ch2Unit_header + "," + ch2Unit);
            strToCSV.Add(testOrder_header+","+testOrder);
            strToCSV.Add(testType_header+","+testType);
            strToCSV.Add(sampleNum_header + "," + sampleNum);
            
            //Start adding testTable
            strToCSV.Add(testTable_header);
            strToCSV.Add(point_tableHeader+","+target_tableHeader+","+low_tableHeader+","+high_tableHeader+","+order_tableHeader);
            foreach (DataRow tableRow in testTable.Rows)
            {
                if (checkIfAllRowEmpty(tableRow) == false)//If row is not empty, then add table row to strToCSV
                {
                    string rowStr = "";
                    for (int colIndex = 0; colIndex < testTable.Columns.Count; colIndex++)
                    {
                        rowStr += tableRow[colIndex];
                        //If it is not the last column, add "," to end
                        if (colIndex < (testTable.Columns.Count - 1))
                            rowStr += ",";
                    }

                    //Add each row of datas into strToCSV
                    strToCSV.Add(rowStr);
                }
            }

            return strToCSV;
        }

        //This method return all test datas into a single String, with \n instead of new line
        public string GetCsvStr()
        {
            string strToCSV = "";
            strToCSV+=testID_header + "," + testID+"\\n";
            strToCSV+=defaultTest_header+","+defaultTest+ "\\n";
            strToCSV +=pointAmount_header + "," + pointAmount + "\\n";
            strToCSV+=fullScale_header + "," + FullScale + "\\n";
            strToCSV+=low_header + "," + low + "\\n";
            strToCSV+=high_header + "," + high + "\\n";
            strToCSV+=percent_unit_header + "," + percent_unit + "\\n";
            strToCSV+=ch1Unit_header + "," + ch1Unit + "\\n";
            strToCSV+=ch2Unit_header + "," + ch2Unit + "\\n";
            strToCSV+=testOrder_header + "," + testOrder + "\\n";
            strToCSV+=testType_header + "," + testType + "\\n";
            strToCSV+=sampleNum_header + "," + sampleNum+"\\n";

            //Start adding testTable
            strToCSV +=testTable_header + "\\n";
            strToCSV+=point_tableHeader + "," + target_tableHeader + "," + low_tableHeader + "," + high_tableHeader + "," + order_tableHeader + "\\n";
            foreach (DataRow tableRow in testTable.Rows)
            {
                if (checkIfAllRowEmpty(tableRow) == false)//If row is not empty, then add table row to strToCSV
                {
                    string rowStr = "";
                    for (int colIndex = 0; colIndex < testTable.Columns.Count; colIndex++)
                    {
                        rowStr += tableRow[colIndex];
                        //If it is not the last column, add "," to end
                        if (colIndex < (testTable.Columns.Count - 1))
                            rowStr += ",";
                    }

                    //Add each row of datas into strToCSV
                    strToCSV+=rowStr + "\\n";
                }
            }

            return strToCSV;
        }
    }
}
