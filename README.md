# Web-Api-CoffeeMug
Project created with .NET Core 3.1

## Testing some operations of the application

Application was tested with Postman and Web browser.

### POST
Firstly, there were added a few records. Id is assigned automatically and the method returned it.

![screen1](/ProjectDocumentationItems/post.JPG)

### GET
There are two ways to see records: by getting all of them or getting one record with Id.

![screen2](/ProjectDocumentationItems/get.JPG)
![screen3](/ProjectDocumentationItems/getId.JPG)

### PUT
To update a record in data base, there is a need to give Id, Name and Price. 
If all values are proper changes are saved in data base (record with "FantasyBook"):

![screen4](/ProjectDocumentationItems/afterPut.JPG)

### DELETE
DELETE returns Status 204 if it deletes a record from data base.

![screen6](/ProjectDocumentationItems/delete.JPG)

### Validation
![screen7](/ProjectDocumentationItems/wrongId.JPG)
![screen8](/ProjectDocumentationItems/errorNoId.JPG)
![screen9](/ProjectDocumentationItems/noName.JPG)

### Data base
To save changes in project is created local data base. There was used Migration to create db based on the data given in the Model.

![screen9](/ProjectDocumentationItems/db.JPG)
