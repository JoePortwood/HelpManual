A system that allows different control types to be added onto pages for different purposes 
I set up the purpose as a help manual for an example

Make sure that your computer user name is in the admin group to make any changes to the pages

To create a new section on the help page add an object type 
and then use that object type in a form object to add it to the page

To make this application I used .Net Core MVC.

To make the different tags display I save the tag type to the database then have a switch case statement
 with the different tag types available and using a custom HTML helper I convert these tag types into actual controls.

Only admin users listed in the application config can edit or remove controls from any of the pages. 
The admins are verified using a policy checker from the AddAuthorization service.

To see who has viewed a page the usage page can be used to view users. 
Users can only look at the next page if they have looked at the previous pages 
- a cookie is stored to remember the furthest page the user has view.

Created by Joseph Portwood 28/11/2018