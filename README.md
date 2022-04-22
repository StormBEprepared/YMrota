# YMrota
Hello!
  This is a beta version of the application which holds the algorithm for a fair role rotation within yard marshall team members at sxw2 Amazon - dayshift.
The whole project was done using open source IDE Visual Studio, C# programming language, winforms extension and .NET specific ideologies.
  It consists of two pages: 
![image](https://user-images.githubusercontent.com/96778964/164802789-3810b97b-d7ec-48c1-a7c6-c8313999c8a2.png)
  The main page where the user chooses from all the possible registered yard marshalls the ones which will be available for the days shift. As it is a safety driven
job all of the yard marshall positions will be occupied by 8 marshalls so a minimum of 8 dayshift associates is necessary to be checked before going to the second
page. (excluding morning shift associates which are at the top of the lists)
Once the required number of members are checked the toggle button can be pressed to lock the current state and the Confirm button to go to next step.
![image](https://user-images.githubusercontent.com/96778964/164803190-d5f0aafd-2bc8-41f1-a8b2-72631211bf6a.png)



  The second page is showing all of the selected marshalls, their training and the past positions that they occupied.
![image](https://user-images.githubusercontent.com/96778964/164803272-2d3a1233-cf14-461b-96eb-f2d325089f69.png)


  Once you press the generate rota button the rota for the given headcount will be printed using an algorithm that first deploys the morning shift associates
without a specified role as per the shift fluctuating list of tasks. The second ones to be deployed are the one with risk assesment to make sure that they
will be deployed on proper positions according to their health needs. The last ones will be the other associates. All of the deployment process is using 
the algorithm created for a better role rotation that uses the past deployments for each of the associates so they will be deployed on different spots throughout 
the week. However due to the limitation given by training, risk assessments and number of roles that does not mean that the associate will do a different role 
every day as there will still be a chance for a selected marshall to be deployed twice in the same position in the same week. 

  Once the rota is printed there is an option to extract all data in a excel file as well if that is more confortable for the user. The user can do that by 
pressing the Extract Excel button so an excel file containing all the deployment data will be opened and ready for editing or to be introduced in a report.
![image](https://user-images.githubusercontent.com/96778964/164805135-c3829a72-decd-498e-baca-455e0e7bc205.png)

  The application is currently under testing phase. The future improvement plan is looking at a way to create the deployment rota for the upcoming week automatically
without the user to print it every day, making the day by day deployment necessary only if one or many associates are not present for their shift. This 1 week rota will be saved as an excel file and sent to the TOM supervisors on email every week. The plan to give front-end and back-end specific days for sortation is currently under consideration but not implemented as that will mean the whole algorithm will have to be changed.
