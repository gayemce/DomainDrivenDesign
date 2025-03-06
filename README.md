# Domain Driven Design with Clean Architecture

This project combines **Domain Driven Design (DDD)** concepts with **Clean Architecture** principles to provide a practical software development model for real-world scenarios.

## What is Domain Driven Design?

**Domain Driven Design (DDD)** is a software development approach used to reflect complex business processes into software solutions. In this project, key DDD concepts such as **Entity, Value Object, Aggregate Root, Domain Event, Repository, Factory Pattern** have been implemented to create a modular, testable, and extensible architecture.

## DDD Concepts Covered in the Project

### 1️⃣ **Entity**
- **Entities** are business objects with a unique identity.
- Examples: `Category`, `Order`, `Product` and `User` are modeled as Entities.

### 2️⃣ **Value Object**
- Immutable objects without a unique identity.
- Examples: `Name`, `Email`, `Password`, `Address`, `Currency` and `Money` are modeled as Value Objects.

### 3️⃣ **Aggregate Root**
- Represents a set of related entities that are treated as a single unit.
- Example: `Order` is an Aggregate Root that contains `OrderLine`.

### 4️⃣ **Domain Event**
- Used to model important events occurring in the system.
- Examples: `OrderDomainEvent`, `UserDomainEvent`.

### 5️⃣ **Repository**
- Manages Entities and Aggregates.
- Examples: `ICategoryRepository`, `IOrderRepository`, `IProductRepository` and `IUserRepository` provide an abstraction for data access.

### 6️⃣ **Factory Pattern** 
- Centralizes object creation and abstracts the instantiation details.
- Example: The `CreateUser` method encapsulates user creation logic and ensures users are created following certain rules.

## How is Clean Architecture Applied?

This project follows **Clean Architecture** principles and is structured into layers:

```plaintext
📂 src
 ┣ 📂 Domain          # Core DDD concepts and business logic
 ┣ 📂 Application     # Services managing use cases
 ┣ 📂 Infrastructure  # Data access, external service integrations
 ┗ 📂 Presentation    # API or UI layer
```

- **Independent Layers:**
  - The `Domain` layer is completely independent with no external dependencies.
  - The `Application` layer interacts with the `Domain` layer and manages business rules.
  - The `Infrastructure` layer handles data access and external dependencies.
  - The `Presentation` layer contains the API or UI.

- **Dependency Rule is strictly followed.**
-  Developed according to **SOLID** principles.
-  Implements **CQRS** architecture.


## Setup and Running the Project

1. **Install dependencies:**
   ```sh
   dotnet restore
   ```
2. **Apply database migrations:**
   ```sh
   dotnet ef database update
   ```
3. **Run the project:**
   ```sh
   dotnet run
   ```
