# SuissePOC
SuissePoc Request

Some insights:
I could add easily a test layer

Updates ( 3/19/2023 ) --- 

- Created an Application Layer.

- Segregate the Infra and Domain from the Console ( View Layer per say ), now the console calls the Application and the application deals with the info comunicating with the services in the domain layer.

- Made a Config fin layer for clean code, i didnt want to polute the Application layer.

- Created an IOC CrossCutting for segregate the layers properly.

- Still inted to create some CRUD tests project just to shows how the layers could interact better, but i used Reflection, Generics and clean code to build a simple mock just for show how i would make.

- I am very concern with clean code, SOLID and a easily manageable code so i just created a private method for each Bussiness Rule in my service and them made a public method that can be consumed for set the Category, i believe that in a real case scenario a lot of this domain would differ, but for the exercise i think this simple aproach goes well.

Question 2:

Just add the new property to the entity Trade and the DTO  them insert the new category in the Enum, modify the method in the service to reflect this new Business Rule
to make it work. I would create a new private too to define the Business Logic and keep the code readable and organized, even to prevent further bugs.

