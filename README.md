# .NET 8 Blazor WebAssembly CRUD Operations 

## Overview
Welcome to my GitHub repository, where I dive into the intricacies of implementing CRUD (Create, Read, Update, Delete) operations using Blazor WebAssembly in the .NET 8 framework. This project is a testament to the evolving capabilities of Blazor and its WebAssembly render mode, allowing for rich, interactive web applications. I've designed this project to showcase how to seamlessly integrate client-side Blazor with server-side operations, leveraging the full potential of .NET 8.

## Key Features
- **Blazor WebAssembly Integration**: Utilize the Blazor WebApp template to create a project that runs in the browser using WebAssembly, ensuring a smooth and responsive user experience.
- **CRUD Operations**: Implement comprehensive Create, Read, Update, and Delete functionalities, interfacing with a server-side database through Entity Framework.
- **Dynamic Data Handling**: Showcase dynamic data manipulation within the Blazor application, providing real-world applicability for managing entities such as video games.
- **Modern Project Structure**: Embrace the latest project organization standards in .NET 8, including the separation of concerns between client and server logic, and the use of Pages and Layout folders for intuitive navigation.
- **Stream Rendering and Enhanced Navigation**: Leverage advanced features such as stream rendering for efficient data loading and enhanced navigation for interactive user interfaces.
    ![Screenshot 2024-02-05 093011](https://github.com/bestcoolestp/DotNet8BlazorWebAssembly/assets/108534975/d18dcd61-ab42-4893-87a4-52505f72deed)

## System Architecture

### Design
The architecture of this project is split between the client and server sides to leverage the full stack capabilities of Blazor and .NET 8:

- **Client Side (Blazor WebAssembly)**: The client-side application is built using the Blazor WebAssembly project template. It includes interactive pages for performing CRUD operations, where each operation is handled through user interface components like buttons and forms. The client side interacts with the server via HTTP requests, utilizing the HttpClient service for data fetching and manipulation.

- **Server Side**: The server side is set up using ASP.NET Core and Entity Framework for managing the database operations. It includes a Data Context for entity management and Controllers to handle API requests. The server side is responsible for executing the CRUD operations requested by the client side and communicating the results back.

### Interactive Render Mode
The project specifically utilizes the WebAssembly render mode for Blazor components, ensuring that the application runs directly in the browser, providing a seamless user experience. This mode is chosen during project setup and is reflected in the configuration of the Blazor WebApp.

### Data Handling
The Entity Framework is used to define models and perform database operations. The project includes a sample model (e.g., VideoGame) with properties such as ID, Title, Publisher, and Release Year. The server-side Data Context is configured to manage these entities, and seed data is provided to demonstrate functionality.

### CRUD Implementation

- **Create**: Entities can be added through the client interface, with data being sent to the server for persistence.
  ![Screenshot 2024-02-05 093400](https://github.com/bestcoolestp/DotNet8BlazorWebAssembly/assets/108534975/5b7a2877-d5ed-41e5-b811-f58376e47ffa)
  ![Screenshot 2024-02-05 093411](https://github.com/bestcoolestp/DotNet8BlazorWebAssembly/assets/108534975/b911673e-ffcb-4c24-a40a-0bee786fafae)

- **Read**: The application fetches and displays data from the server, utilizing stream rendering for efficient loading.
  ![Screenshot 2024-02-05 093235](https://github.com/bestcoolestp/DotNet8BlazorWebAssembly/assets/108534975/36a6a644-b8bb-4e9f-a6c4-472ee01ed00e)
  ![Screenshot 2024-02-05 093426](https://github.com/bestcoolestp/DotNet8BlazorWebAssembly/assets/108534975/6b042d70-e9a8-4eb6-8fcd-a771f0698a6c)

- **Update**: Existing entities can be modified through the client interface, with changes being reflected in the server database.
  ![Screenshot 2024-02-05 093508](https://github.com/bestcoolestp/DotNet8BlazorWebAssembly/assets/108534975/bf3e5189-a3c2-4b96-80fd-f79bf0d0f461)
  ![Screenshot 2024-02-05 093528](https://github.com/bestcoolestp/DotNet8BlazorWebAssembly/assets/108534975/400ccc41-c79e-4b37-ae3c-3fe220f74913)

- **Delete**: Entities can be removed through the client interface, with the server handling the removal from the database.
  ![Screenshot 2024-02-05 093553](https://github.com/bestcoolestp/DotNet8BlazorWebAssembly/assets/108534975/72ae06e3-f89c-4fab-a010-502fdcc68f08)
  ![Screenshot 2024-02-05 093604](https://github.com/bestcoolestp/DotNet8BlazorWebAssembly/assets/108534975/20d3c9b2-9e87-416a-a93b-5078d37b0817)
