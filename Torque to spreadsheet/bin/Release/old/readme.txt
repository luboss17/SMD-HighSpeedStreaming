Hello!
Welcome to AWS Torque to Spreadsheet, a new program from AWS. This is the first Beta release, so please
report any bugs to Taylor@awitness.com

Operation is simple:
1. Open the program (just run Setup.exe to install, or run the file without installation by running the "Torque to Spreadsheet.exe" file. The installed version can be removed in the windows add/remove programs dialog) If you cannot run or install the program, see the note at the end of this document.

2. Connect and power on your AWS tester (this does not have to be done first, but obviously needs to be done at some point. also, currently only the 4050 and QC has been tested, but it should work with most of our products. )

3. Select the COM Port, if you have more than one. The program automatically selects the first avaliable COM port on your machine, and only provides the names of COM ports actually detected on your machine, to minimize confusion.

4. Click the Open/Close Serial Link button to open the COM Port. If the label at the bottom of the window says "Status: Open", then it succeeded and you can immediately see tester data in the program window by sending data from the tester. The program shows the last value recieved, but will not save your data in any way.

5. To save data, this program allows the user to dump values directly into a spreadsheet or text document. Simply click "Activate Spreadsheet Transfer", ensure the serial port connection is open, then open any spreadsheet program (Excel, Google Spreadsheets, OpenOffice, etc) and highlight the cell you would like to start entering data into.

When you send data from the tester, the torque value will be entered into the first cell, followed by the units in the next cell. As you send more readings, they are entered beneath the previous reading in the spreadsheet (except google spreadsheets, where each value is one cell below and to the right of old values when units are not suppressed). Units can be suppressed by clicking the checkbox in the program window.

Note: Avoid sending data in spreadsheet mode to programs other than word or spreadsheet applications, as the Torque to Spreadsheet output could cause problems for the active program. This is only a concern when spreadsheet mode is activated and the tester is actively sending Data.

What else can Torque To Spreadsheet do? When combined with some simple Excel formulas or Visual Basic Scripts, you can really do a lot with your Data. Set up a graph to display the output of a few cells with Torque data in them and you can easily graph new data by just clicking at the top of the list and running your tests again. Or use conditional formatting in excel to highlight stray values red. If you're not familiar with conditional formatting, try googling it, it is very helpful. You can easily set two cells as your top and bottom values, and then use conditional formatting to Highlight any cells in red that do not fall within your upper and lower bounds. If you are familiar with Microsoft's Visual Basic, you can write scripts that will automatically compute a pass or fail cert after a certain number of tests. Visual Basic is very easy to use, and like most things, lots of information can be found through Google if you aren't familiar or need a refresher.

Don't want to spend all your time Googling? AWS can help. If you need us to help you with a spreadsheet, we may be able to do that at no charge. If you need more advanced help or programming, we can help you with that too, but there may be a fee. We are not reserved to simply entering values into excel, we are working on new software that will allow values to be written to a database, live torque readings to be displayed on the web, and more, just tell us what you need!
Thanks,
Taylor Alexander,
Advanced Witness Series, Inc.
AWitness.com


Installation problems:
If you have any problems running the software, you may need the .Net framework from microsoft, which you can get here:
http://www.microsoft.com/downloads/details.aspx?FamilyID=0856EACB-4362-4B0D-8EDD-AAB15C5E04F5&displaylang=en or if that link does not work, by googling ".net 2.0 framework" without the quotes, and downloading the file from microsoft (should be the first result).