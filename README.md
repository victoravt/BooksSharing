#GitHub Copilot Hackathon  
Welcome to the GitHub Copilot Hackathon! This is a README file that will help you keep track of your progress during the hackathon. For each subtask, there are placeholders for you to input the time you spent on that task.

Developer Name: [Victor Avtandilyan]
Developer Email: [victor_avtandilyan@epam.com]

### Subtask 1: Implement the foundational structure of the application
Time spent on this subtask: [1h + 30min of env setup]
Comments: The Copilot generated secrets for dev, test, prod envs connection strings based on my written configuration string for dev env. 

### Subtask 2: Implement the basic data models and database schema
Time spent on this subtask: [7h]
Comments: Genere and Tag entity fields was suggested by Copilot. 
            Amazingly copilot genereated GenericRepository methods. But didn't went to deep of application to find that Db access context class is 'AppDbContext' not 'BooksSharingContext' as it generated. But still it's doing good :)
            Also the Copilot recognize interface that class should implement and suggests apropriate methods.
            It also genereated almost all DbSets in AppDbContext class.

            Conculsion: Majority of time is spent to define right relationships between entities and there deletion behaviour. For this purpose copilot of course will not help you. But for mechanical DbSet properties writting, services injections in Program.cs it is helping. But after all you should be carefull what the Copilot genereated, recheck it. So it's also time consuming. Maybe you win in the time of mechanical coding, but loose time to check at to be sure that there is no minor mistakes from Copilot.


### Subtask 3: Implement authentication for application
Time spent on this subtask: [insert time here]
Comments: 

### Subtask 4: Implement a mechanism for adding and editing a book
Time spent on this subtask: [insert time here]
Comments: 

### Subtask 5: Implement a dashboard with available books and the ability to filter them
Time spent on this subtask: [insert time here]
Comments: 

### Subtask 6: Implement a user profile page 
Time spent on this subtask: [insert time here]
Comments: 

### Subtask 7: Implement a mechanism for transferring a book from one user to another
Time spent on this subtask: [insert time here]
Comments: 

### Subtask 8: Implement a page with the history of book movements between users
Time spent on this subtask: [insert time here]
Comments: 

### Subtask 9: Implement unit tests
Time spent on this subtask: [insert time here]
Comments: 

### Subtask 10: Implement a recommendation system 
Time spent on this subtask: [insert time here]
Comments: 

Common comments on Hackathon:
The copilot don't take into account that it suggests class property which obviously is datetime (ex DueDate, or somthingDate)