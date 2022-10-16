# Database Creation

- Areas: Used to organize in large apps and create another hierarchy level. I.E.
    ```
    Project
        Shopping
            Models
            Views
            Controllers
        Checkout
            Models
            Views
            Controllers
    ```
- Context vs. Namespace vs. Schema vs. Registration
  - Namespace: scoping of variables, classes, and functions.
  - Schema: organization of database. The "columns"...? Or the database overall
    - DBO: "namespace" of the database
    - DDL: Data Definition Language (the "headers")
  - Registration: schema initialization?
  - Context: A DbContext instance represents a session with the database and can be used to query and save instances of your entities. DbContext is a combination of the **Unit Of Work** and **Repository** patterns.
    - https://learn.microsoft.com/en-us/dotnet/api/system.data.entity.dbcontext?view=entity-framework-6.2.0 
- Scaffolding: generating code functionalities based on another defined section...?
  - Model to Controller
  - DB to Model
  - Model to Context
- Migrations: essentially moving of databases (and possibly restructuring the target).
  - May also apply to overall database population from a source? As in, from a test sample, or non-DB source (i.e. website)? What about updating the model to DB and vice versa, is this migration as well?
- Scaffolding and Migrations are ORM
  - Migrations = Code First
  - Scaffolding = DB First
- EF = Entity Framework Core: Database Framework
- .NET Core Framework

Helpful Theory Sources:
- [Google's Glossary](https://cloud.google.com/architecture/database-migration-concepts-principles-part-1) 

---

- Dependency Injection (again)
  - Several Types, but construction dependency seems common
  - Use Case: you want a class to pull data from a database/excel sheet/pipe command/whatchamacallit. But if you have it directly connect with a `new SqlConnectionClass()`, then you're hard-coding to one solution (and schema?) of storage -- rigid, inflexible, and mixing of responsibilities, all bad stuff. So you use an interface as a mediator, it defines what the parameters are needed, and `SqlConnectionClass()` is never created explicitly -- instead when it's the desired format, `IModelWhateverConnection` is called upon and instantiates the class it needs.
  - The **DI Container**: `Services.AddScoped<IModelWhateverConnection, SqlConnectionClass>()`, *I think*, would be how you'd "put something in" -- registers the interface with that specific solution (can use transient and singleton as well). Thus if the storage solution changed, then only this line would change?
  - Hollywood principle: "dont call me, Ill call you"
    - EventListeners are a pattern of DI
    - Create an interface where others call you instead of you calling them

---

- Encoding?
  - Encode to prevent JavaScript hacks with code input for parameters...?
- Controllers: why separate controller files? Are they simply another level of hierarchy?
- Late Bound

- Password Hash: Salt and/or Pepper
- Hash
  - One-way function
  - Cryptographic Function
    - f
  - Ge
  - Rainbow Tables
- Hash is one-way function, but several *properties*:
  - **Cryptographic**: 
    - Sufficiently Long (choosing space)
    - Sufficiently Long (choosing time)
    - Takes a long-time to compute
      - One second is short for a human, but long for a billion guesses (rainbow table)
    - Random Execution Time: prevents *side-channel attacks*
  - **Collision Space**
    - Collisions: different inputs equal the same output
    - Frequent vs Infrequent Collisions: sometimes you want them to collide, sometimes (such as passwords) you don't
  - High or Low Entropy:
    - How much impact do changes in the input affect the output (i.e. "Hello":f2345 and "hello":af2345 vs "Hello":f2345 and "hello":84284)
    - Lengths of Hashes based on Input
- Open SSL: bunch of stuff regarding best-designed hashes
- sha256
  - Used in UCD


---

Terminal Commands:

## Scaffolding

CLI for Scaffolding (auto code gen) and Context Creation (CarsContext)

```ps1
 dotnet-aspnet-codegenerator controller -name CarsController -m Car -dc CarsContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite
```

- Solution must be build-ready beforehand. `--no-build`, afaik, is wonky to use. May be a hassle on bigger projects, something to keep in mind.
- Alternatives for context creation?

## Migration Manager

```ps1
dotnet ef migrations add Initialization
dotnet ef database update
```

---

## Jira

- Template seem unlikely? A way to store cards? If not, link form original or each week?
- GitHub Linking -- do you link Jira commits? (I can check this myself)

---

We dont use anything to manage front-end UI (yet?); we dont use areas.

Opinionated/Uniformity vs Freeform of a Program (forcing a specific method).