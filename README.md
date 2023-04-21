 # 🤖 C# Local Olympiad Subject

## This project demonstrates a C# project that :
  - has functional login and register functionalities, using an SQL Server Database
  - opens up the "Vizualizare" form after a successful login
    
    
## The "Vizualizare" (View) form :
 - has two radio buttons : Draw and Delete
 - on load the pictureBox loads the already existing triangles from the database
 - if Draw is selected :
  - on each click a point is added to the pictureBox
  - between the first two points a line will be drawn
  - on the third click a new triangle is formed and added to the database
- if Deleted is selected :
  - each click on one of the points will detele all the triangles from the database that include it
  - the form is reloaded and the remaining triangles are loaded too

![image](https://user-images.githubusercontent.com/68704220/233563591-c0f95aac-8b93-4162-98dd-65e1eb2afa71.png)
