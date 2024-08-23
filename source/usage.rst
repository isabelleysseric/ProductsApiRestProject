========
Usage
========

This section provides instructions on how to use MyApiProject.

Starting the API
================

To start the API, navigate to the project directory and run the following command:

.. code-block:: bash

   dotnet run

The API will be accessible at `http://localhost:5000`.

API Endpoints
=============

MyApiProject provides the following endpoints:

Items
-----

- **GET** `/api/items` - Retrieve all items
- **GET** `/api/items/{id}` - Retrieve a specific item by ID
- **POST** `/api/items` - Add a new item
- **PUT** `/api/items/{id}` - Update an existing item
- **DELETE** `/api/items/{id}` - Delete an item

Products
--------

- **GET** `/api/products` - Retrieve all products
- **GET** `/api/products/{id}` - Retrieve a specific product by ID
- **POST** `/api/products` - Add a new product
- **PUT** `/api/products/{id}` - Update an existing product
- **DELETE** `/api/products/{id}` - Delete a product

Example Requests
================

Here are some examples of how to interact with the API using `curl`.

Retrieve All Items
------------------

.. code-block:: bash

   curl -X GET http://localhost:5000/api/items

Add a New Product
-----------------

.. code-block:: bash

   curl -X POST http://localhost:5000/api/products \
   -H "Content-Type: application/json" \
   -d '{
     "name": "New Product",
     "description": "This is a new product",
     "price": 19.99
   }'

Update an Existing Item
-----------------------

.. code-block:: bash

   curl -X PUT http://localhost:5000/api/items/1 \
   -H "Content-Type: application/json" \
   -d '{
     "name": "Updated Item",
     "description": "This is an updated item"
   }'

Delete a Product
----------------

.. code-block:: bash

   curl -X DELETE http://localhost:5000/api/products/1

Next Steps
==========

- To contribute to the project, see the `CONTRIBUTING.md` file.
- For more details on the API, refer to the `API Reference` (if available).
