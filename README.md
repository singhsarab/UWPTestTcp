# UWPTestTcp
This contains the test app for UWP used for testing Tcp connections.

Instructions for using this app.
1.	Clone the repo to some machine which has the latest VS (for example, VS 15.9)
2.	Open both sln files in VS
3.	Run TcpServer from VS(CTRL+F5), & note the port on which it has hosted server.
4.	Run App1 from other solution, & in the message box, add the port noted in step 3, then hit connect button, you should the App hang for some time, & nothing is printed on console of TcpServer.
5.	Close both TcpServer, & App.
6.	Repeat #3, #4, this time on tcpserver console you should see two messages printed.
