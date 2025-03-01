# Overview
The password manager web application is an application with the main purpose of securely storing the user's sensitive credentials.

# Project Description
The password manager web application is an app that will store a registered user’s login credentials for various websites that they frequently visit and use. Its main purpose is to securely store a list of credentials for the user instead of using physical space to store passwords like writing down their passwords on a notepad or piece of paper. All the user needs to do to see their list of passwords is to register an account into the web app and log in to their account, and if they have additional passwords that they have, they will be able to add I into their list using their account for the web app.

[Link to full Project Description](Documents/ProjectDescription.docx)

## Solution Architecture Diagram

![SolutionArchitectureDiagram](https://github.com/user-attachments/assets/942b53f1-5678-4701-8601-6e5551ba2b23)

# Wireframe Diagram (DRAFT)
[Link to Wireframe Diagram in Images file](Images/WireframeDiagram.jpg)

![WireframeDiagram](https://github.com/user-attachments/assets/cf6ce99f-e748-4d40-a3f8-9392c7d51556)

# User Stories
1. As an office worker for a company that needs to log in to many sites for my job, I need to use a password manager web application so that I don’t have to remember each password for the accounts on various sites.
2. As someone who works in the IT security team of the University On-Campus IT team, I need to use a password manager web application so that I can securely store the IT team’s sensitive credentials.
3. As someone who works on multiple devices and rarely stays on one device, I want to use a password manager web application so that I can just use a browser on any device to access my passwords stored in my account.
4. As a worker who works for a company that demands frequent password changes, I need to use a password manager web application that allows me to update passwords so that I can comply with my company’s standards of strong updated passwords.
5. As someone who has many accounts for different websites, I need to use a password manager web application with a lot of storage space so that I don’t need to write all my account credentials on a piece of paper and potentially lose it.

# Use-Case

[Link to Use-Cases document](Documents/Use-Cases.docx)

## Use-Case #1 - Register New User
Description:   Registering New Account for Password Manager Web App

App System:  Registering New User Process

Actor(s):  New Customer

Pre-existing Condition(s):
* User has not registered an account for the app
* User has the welcome page of the web app open on a browser

Scenario:
1.	New Customer clicks the “Register Account” button on welcome page
2.	New Customer is redirected to the register account page
3.	New Customer enters a valid username in the “Username” input text box
4.	New Customer enters a strong password in the “Password” input text box
5.	New Customer re-enters their password in the “Re-Enter Password” input text box
6.	New Customer enters their master pin in the “Master PIN” input text box
7.	New Customer clicks the “Register” button
   
Expected Result:  
New Customer successfully created a new account for the Password Manager Web App and will be redirected to the login page.

## Use-Case #2 - Logging Into Web App
Description:  Logging into their account for the Password Manager Web App

App System:  Logging registered user into web app process

Actor(s):  Registered User

Pre-existing Condition(s):
* User has already registered an account for the web app
* User has the welcome page of the web app open on a browser

Scenario:
1.	User clicks the “Log In” button at the top of the welcome page
2.	User is redirected to the login page
3.	User enters their correct username into the “Username” input text box
4.	User enters their correct password into the “Password” input text box
5.	User clicks the “Login” button on the page
   
Expected Result:  
User has been authenticated and authorized by the app and will be redirected to their main page with their password lists in the web app.

## Use-Case #3 - Adding New Password
Description:  Adding a new password to the list

App System:  Add new password process

Actor(s):  Logged in User

Pre-existing Condition(s):
*	User is logged in to the web app on a browser
*	User has their main page with their password list displayed

Scenario:
1.	User clicks the “Add Password” button on the page
2.	User is redirected to the add password page
3.	User enters the correct name of the website into the “Site name/URL” input text box
4.	User enters the correct username for the website account into the “Username” input text box
5.	User enters the correct password for the website account into the “Password” input text box
6.	User clicks the “Add Password” button on the page
   
Expected Result:  
User has successfully added a password to their list and will be redirected to the main page with their updated list.

## Use-Case #4 - Viewing Locked Password
Description:  Viewing a password on the list

App System:  View password using Master PIN process

Actor(s):  Logged in User

Pre-existing Condition(s):
*	User is logged in to the web app on a browser
*	User has their main page with their password list displayed
*	User already has a few passwords in their list

Scenario:
1.	User clicks the “View/Edit” button for their YouTube password
2.	User is redirected to the View/Edit page of their YouTube account
3.	User clicks the “Reveal Password” button
4.	User is shown an input text box that says “Enter Master PIN”
5.	User enters the correct Master PIN password into the “Enter Master PIN” input text box
6.	User clicks “Submit” button
   
Expected Result:  
User has successfully unlocked and revealed their encrypted password for their YouTube account

## Use-Case #5 - Deleting Password
Description:  Deleting a password on the list

App System:  Delete a single password process 

Actor(s):  Logged in User

Pre-existing Condition(s):
*	User is logged in to the web app on a browser
*	User has their main page with their password list displayed
*	User already has a few passwords in their list

Scenario:
1.	User clicks the “Delete” button for their Spotify account
2.	User is shown a pop-up box with the text “Are you sure you want to delete this?”
3.	User is presented with two buttons along with the pop-up “Yes” and “No”
4.	User clicks the “Yes” button on the pop-up

Expected Result:  
User has successfully deleted a password from the list and will be shown a message on the main page that says “Password has been deleted.”

## Use-Case #6 - Updating Password
Description:  Updating a password on the list

App System:  Update Password Process

Actor(s):  Logged in User

Pre-existing Condition(s):
*	User is logged in to the web app on a browser
*	User has their main page with their password list displayed
*	User already has a few passwords in their list

Scenario:
1.	User clicks the “View/Edit” button for their Gmail account
2.	User is redirected to the View/Edit page for their Gmail account
3.	User clicks the “Edit Info” button
4.	User clicks on to the “Password” input text box
5.	User changes the password to match their updated password for their Gmail account
6.	User clicks the “Update” button
7.	User is presented an input box that says “Enter Master PIN”
8.	User enters the correct Master PIN password into the “Enter Master PIN” input text box
9.	User clicks the “Submit” button
   
Expected Result:  
User has successfully updated their password and will be redirected to the main page.


# Use-Case Diagram

![DiagramUseCaseUML](https://github.com/user-attachments/assets/1f574760-417c-422f-8a88-da4f88c7b8ce)

# Project Requirements Table

| ID | Requirements    | 
| :---: | :--------: | 
| 1 | The software shall display a list of passwords to the registered user’s main page |
| 2 | The add password functionality shall allow the user to add more passwords to their password list |
| 3 | The update/edit password functionality shall allow the user to edit and change a password from their password list |
| 4 | The delete password functionality shall allow the user to delete a password from their password list |
| 5 | If the user’s login/registration credentials are incorrect and/or invalid, the software shall display a message to the user their input is invalid and redirect them back to the register or login page |

# Entity Relationship Diagram

![ERD](https://github.com/user-attachments/assets/bc53d24c-e081-4151-8018-bc0dd52a2930)

# UML Class Diagram

![UMLClassDiagram](https://github.com/user-attachments/assets/4027b771-1626-41d6-a7ea-74a18b3625fd)



