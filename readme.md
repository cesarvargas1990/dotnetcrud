# Simple CRUD API with .NET Core 8

This project is a basic implementation of a CRUD API using .NET Core 8. It includes a simple in-memory storage for managing products and supports operations like Create, Read, Update, and Delete.

## Prerequisites

- .NET SDK 8.0 or later
- A code editor (e.g., Visual Studio Code or Visual Studio)
- Command-line tools (e.g., Terminal, PowerShell, or Command Prompt)

---

## Running the Project

1. Clone the repository or download the source code.

   ```bash
   git clone <repository_url>
   cd <repository_directory>
   ```

2. Restore dependencies (if needed):

   ```bash
   dotnet restore
   ```

3. Run the application:

   ```bash
   dotnet run
   ```

4. The application will start and listen on `http://localhost:5101` by default.

---

## Testing the Endpoints

Here are the endpoints provided by the API:

### 1. Get All Products

**URL:** `http://localhost:5101/api/product`

**Method:** GET

```bash
curl -X GET http://localhost:5101/api/product
```

### 2. Get a Product by ID

**URL:** `http://localhost:5101/api/product/{id}`

**Method:** GET

**Example:**
```bash
curl -X GET http://localhost:5101/api/product/1
```

### 3. Create a New Product

**URL:** `http://localhost:5101/api/product`

**Method:** POST

**Example:**
```bash
curl -X POST http://localhost:5101/api/product \
  -H "Content-Type: application/json" \
  -d '{"id": 1, "name": "Sample Product", "price": 100.0}'
```

### 4. Update a Product

**URL:** `http://localhost:5101/api/product/{id}`

**Method:** PUT

**Example:**
```bash
curl -X PUT http://localhost:5101/api/product/1 \
  -H "Content-Type: application/json" \
  -d '{"id": 1, "name": "Updated Product", "price": 150.0}'
```

### 5. Delete a Product

**URL:** `http://localhost:5101/api/product/{id}`

**Method:** DELETE

**Example:**
```bash
curl -X DELETE http://localhost:5101/api/product/1
```

---

## Adding Swagger Documentation

Swagger is used for interactive API documentation. Follow these steps to enable Swagger:

1. Open `Program.cs` and ensure the following lines are added:

   ```csharp
   builder.Services.AddEndpointsApiExplorer();
   builder.Services.AddSwaggerGen();

   var app = builder.Build();

   if (app.Environment.IsDevelopment())
   {
       app.UseSwagger();
       app.UseSwaggerUI();
   }
   ```

2. Restart the application using:

   ```bash
   dotnet run
   ```

3. Open your browser and navigate to `http://localhost:5101/swagger`.

   You will see the API documentation, and you can test endpoints directly from the UI.

---

## Notes

- Ensure no other application is using port `5101`. If it is, change the port in `launchSettings.json` or use a different endpoint.
- This implementation uses in-memory storage, so data will be reset each time the application is restarted.

---

## Future Enhancements

- Add database integration (e.g., Entity Framework Core).
- Implement authentication and authorization.
- Add error handling and validation.

---

Enjoy building with .NET Core 8! 🚀
