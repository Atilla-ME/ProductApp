# ProductApp is a project developed to understand onion architecture.

EF in memory, MediatR, Automapper tools are used.

Usage example:

On postman:

//To create a product in memory
Post   -->   http://localhost:...../api/product
             body: {
                    "name": "Book",
                    "quantity": 5,
                    "value": 3
                    }
                    
//To get all products created                    
Get  --> http://localhost:...../api/product

//To get a product by id (copy an id from the response you get from the request above. It will be called id below)
Get  --> http://localhost:...../api/product/id
