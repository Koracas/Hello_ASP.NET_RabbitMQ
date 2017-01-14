# Hello_ASP.NET_RabbitMQ

##Setup
To run this project please follow the following instructions:
- Clone the repo
- Install Erlang: http://www.erlang.org/downloads <br>
<sub>used OTP 19.2 win64</sub> 
- Install RabbitMQ: https://www.rabbitmq.com/install-windows.html <br>
<sub>used rabbitmq-server-3.6.6.exe</sub> 
- To setup a queue please run the script provided here: 
Hello_ASP.NET_RabbitMQ\MVC_RabbitMQ\RabbitMQ_Setup\SetupRabbitMQ.bat
  - This bat file will setup the "PangeaRepoQueue" within the RabbitMQ service
  - We use the default exhange for this project   
  - The queue and message are also not durable since they do not need ot survive a server reboot for this project.
- To monitor RabbitMQ 
	- Go to localhost:15672 in broswer
	- Default creds:: u guest | p: guest
-  Open the Visual Studio 2015 solution here:
<sub>Hello_ASP.NET_RabbitMQ\MVC_RabbitMQ.sln</sub>
- Please setup the solution to run multiple startup projects 
	- In the Solution Explorer, select the solution, which is the very top node.
	- Right-click the node to get the context menu.
	- "Set Startup Projects"
	- Expand the Common Properties node, and click Startup Project.
	- Click Multiple Startup Projects
	- Set "Start" action for both Server and MVC_RabbitMQ
- Build the solution
- Generate the local database
	- This project uses the local database server found here: (localdb)\mssqllocaldb
	- The database that will be accessed is named: PangeaRepoData
	- To migrate in the new database
		- Go to the "Package Manager Console"
		- Select "Sever" as the Default proejct
		- Run the "Update-Database" command
		- This will create "PangeaRepoData", which can be accessed from the "SQL Server Object Explorer" Window
	- Please check that the database exists in via the "SQL Server Object Explorer" Window
	- There should be three tables: Owner, Permissions and RepoData
- At this point you should be able to build and run the project.

##Overall Architecture:
- This solution has two projects
	- **Server** is a .Net Core Console Application used as:
		- A consumer to reads messages from RabbitMQ
		- Pulls down the repository data from  api.github.com/orgs/gopangea/repos 
	- **MVC_RabbitMQ** is a .Net Core Web Application used to:
		- Send a "LoadData" message to RabbitMQ via the "/LoadData" endpoint
		- View repository data on the database via the "/Repositories" endpoint
		- Both of which are accessable from the top nav bar
- Building and running the project will start up both Server and MVC_RabbitMQ.
- Have the RabbitMQ sever running the background.
- Click "LoadData" and the workflow outlined on the home page will occur.
- Please note that though all the data is not shown in the "/Repositories" endpoint is all there in the code.
