# CMPG_323_Project_2_32263988
Methods were not changed and still use the same names. The controller methods like Categories still use the FromBody and the user can click on any attribute and press try it out, then execute. The only different methods are the Authentication methods which use FromQuery to create accounts and log in.

## Security
When I push my ASP.NET project to the repository, I will use. gitignore to prevent sensitive files containing credentials from being pushed. For instance: 

appsettings.json
.gitignore file
and Connect.udl

# ACCESSABILITY
Administrators use the application's authentication and authorization information security procedures to protect both systems and data. These will aid in controlling the system's accessibility. There would be two sections: one for the stakeholders (admin) and one for the users.

## Stakeholders
When stakeholders access the application for the first time, they must register in the admin registration form. There are fields that must be filled out, and if the admin misses any of them, the application will indicate that one is missing. When the admin register, their username will be used to log in and will not be used to register again. The admin can log in and manage the system after registering.

To log in, the administrator must enter their username and password. 

## Users(client)
The user must also fill out the register-user form. All of the fields must be completed before the registration can be completed. As a result, the user can log in. If the username is already in the database, the application will prompt the user to create a new username. Because it will be used to log in, the username must be unique.


## References:
#### YouTube video:

valand C. 2022, 6 Aug. Updating data with JsonPatch 13 of 18 Web APIs for Beginners [YouTube video]. https://www.youtube.com/ Date of access: 22 Feb. 2019.

#### WEBSITE:
Sarathlal Saseendra. 2020. Authentication And Authorization In ASP.NET Core Web API With JSON Web Tokens https://www.c-sharpcorner.com/article/authentication-and-authorization-in-asp-net-core-web-api-with-json-web-tokens/ Date of access: 05 Sep. 2022.

Anon. 2020. Issuer and Audience in JWT .net core https://stackoverflow.com/questions/62153268/issuer-and-audience-in-jwt-net-core Date of access: 05 Sep. 2022.

## DOC
Anon. (n.d). Setting UP API Doc https://docs.google.com/document/d/1AMr_Gf4FEWC4N53Yea0k4makXSRpV2yIio3zYoHMHpQ/edit Date of access: 07 Sep. 2022.
