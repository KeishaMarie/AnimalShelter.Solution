# Animal Shelter

#### By Keisha Hepner

#### Track animals in a shelter with authentication

## Technologies Used

* C#
* Entity
* .Net 5
* Identity
* Asp.NetCore MVC
* MySql
* JavaScript
* JWT

## Description

This is an API that tracks animals in a shelter with create, update and delete functionality. You are able to search for an animal by name, age or species. Registration and Login is required for access to API.

## Setup/Installation Requirements

* Clone repository using URL https://github.com/KeishaMarie/AnimalShelter.Solution.git
* Run dotnet restore and dotnet build
* Create a file titled appsettings.json under the project folder and insert the following code:
![appsettings](/READMEimg/appsettings.png)
* Update the UID and Password with your own
* update the secret string with your own. You will need to use a random string of 32 letters
* Run dotnet ef migrations Initial
* Run dotnet ef database update
* Run dotnet build then dotnet run to run the application

## API Documentation

* You will need to create a token. I used Postman.
* In Postman, insert the following URL: http://localhost:5000/api/authmanagement/register
* In the body, choose JSON and then add the following code as a POST request:
* ![tokenauth](/READMEimg/tokenauth.png)
* A token will be genereated in the response. Under AUTH, choose Bearer Token and copy your token into the token box.

* Endpoints:
* ![endpoints](/READMEimg/endpoints.png)

* To utilize POST and create a new instance of an animal:
* ![postcreate](/READMEimg/post_create.png)

* Example Query: https://localhost:5000/api/Animals/1





## License
Copyright (c) <2022> <Keisha Hepner>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

