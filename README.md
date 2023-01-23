# List of Projects - Asphalt Departament

Information and requirements of the project and more.

## Objetive of the project

Build a small solution to the register of the projects in the asphalt department of the company. This solution is going to be used by the employees and sellers of the company (more exactly)

## Requirements of the project

This are the requirements of the solution

| Requirement | Description | Level of Impact | Solution |
| --- | --- | --- | --- |
| Register the Projects of the company | Build a list of the projects. This projects are register for the sellers | High | Build a Table in a DB (any type) to register the projects with their basic information |
| Block the delete and update operations of the projects register  | The delete and update operations are block and this depend of the type of user  | Moderate | Can be use rols and users to filter the actions in the app, filter by the type of user |
| Filter the type of users That access to the app (Sellers and admins)  | The sellers only have access to their projects registered. The admin users have total control of the app, and this can be delete or modificate the projects | Moderate | Create 2 Tables in the DB to register the users and the rols of any user. |
| Register the offers made by sellers | Create a list of offers made by the sellers in the DB and give a consecutive number to any offer  | Minimum  | Create a table to add new offerts |
| Export Data to Excel | Export the list of projects or the offers to excel to the proccess of the data | Minimum | Create a small component to export the data to excel spreadsheet |

## Actual process of work

The actual process of work in the company is using an excel documents stored in the NAS unit in the network. Exists 2 documents used (one for register the projects and the other to the offers)


### Advantages and disadvantages

Advantages of use this documents 

- Is a simple way to use. Is only neccesary use Office and stay connected to the network
- Is simple to modificate.  Is was neccessary change of add new data to the list,  only add new columns to the document.

Disadvantages of use than documents:

- **Control of modifications**: anyone with access and modification or delete data from the documents. is more difficult block the remove permission.
- **Avariable:** is someone have the document open, nobody can edit the document, becacause the NAS unit don’t allow the multitasking access

## Ideas based in the requirements

For the solution of this issue, exists to ways to control the access and CRUD operations in the spreadsheets. 

1. **SpreadSheets with Programming**: using a spreadsheets with programming modules in VB to configurate the permissions of modifications in this. The problem is the avariable for the others and the maintenance (if is necessary do any modification in the spreadsheet, the code must be reviewed) Also the spreadsheet is going to be block by one user during their access (no multitasking)
2. **Basic app with DB**: using this method, is more difficult and have more time to implement, but this way allows the multitasking and a better use of the resources. The disadvantage is the reviews. If is neccessary add or delete any data from the app, is going to be obligatory review the code and the database used.

The idea used for this topic is going to be the basic app with a DB. For the size of the project, the app will be build in Windows Forms app and connected to a SQL Server Database. The programming languaje is C#. 

![Captura_de_pantalla_2023-01-18_120911](https://user-images.githubusercontent.com/43178863/213269834-ff8798da-48f4-418e-b906-4dacf5654f23.png)


This app in production is going to be installed in the computers used for the sellers and employees related with the information. For the connection to the DB is necessary used the LAN of the company or stay connected with the VPN.

To the control of the users and what kind of information can see, the users must be loggin before start to use the app


![Captura_de_pantalla_2023-01-18_121031](https://user-images.githubusercontent.com/43178863/213269857-ff112853-ea74-4221-8fed-844f5fd7bd4d.png)

## DB Design and Entities

For the size of the project and the information to be store, is most simple use a small DB with a relational model. this is useful to generate filters of the information and group the data in the DB. The engine of DB is going to be SQL Server, because is the actual engine used in the company, and the connection with Windows Forms and .Net is more simple (using entity framework)

To create the Database used in this project, the important entities abstractions are the following:

| Entity | Description |
| --- | --- |
| Projects | Project of asphalt. This entity has the basic information of the project (start date, end date, amount, Id of the project, description, etc) |
| Offers | Basic information about the offer. The id of offer, the customer, and the characteristics of the offer (require asphafalt, etc) |
| Customers | List of customers linked the project. this permit to the system agroup the projects by customer |
| Users | The basic information about the user of the system, to register who created or edit the data in the DB and also the type of user (admin or seller) |
| Roles | The rols in the app and what kind of permissions have (Create, delete or update) |

This is the schema propuse for the database (relational db)

![Captura_de_pantalla_2023-01-18_122140](https://user-images.githubusercontent.com/43178863/213269768-390c0348-8b6e-465f-9127-016e418c5a26.png)


## Structure Of the application

This is the structure and navigation in the application build it in windows forms using C#:

![Captura_de_pantalla_2023-01-18_125045](https://user-images.githubusercontent.com/43178863/213269786-797126a0-4897-49f1-b140-27a5dde5057c.png)


