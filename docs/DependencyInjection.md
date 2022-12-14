- Global
  - Contexts
    - Always the Same, everywhere and always
      - Static, Global variable
    - Changes per user
      - Static function
    - Changes per item
      - Static function
    - Changes per site
  - Lifecycle
    - Any non-trivial lifecycle = **Service** (read up)
      - Dependency Injection
      - Filters/Manages ~~data~~ contexts
      - Could just be a calculation
      - Contextual Procedure 
  - Input-based?
- ViewModels
  - Can collapse multiple models into one for a View
  - Can replace multiple service calls inside a View
  - Use them because they're easy
  - Account Pages
  - Password Resets
- Note: can tease Eric about not knowing SASS
- Dependency Injection
  - Container (Registry, List, "Phone book" of many objects)
  - Manages lifecycle of objects within registry
  - Lifecycle, not Memory, Management
  - Inject = Getting Out of Container
  - Approximately, Container = Services = Provider = Service Provider = Dependencies
  - Lifecycle
    - The object calling the object does not get constructor -->
    - **Rule-Based Constructor Calling:**
    - Transient vs Scoped vs. Singleton Lifecycles
      - Transient: every time a service asks for a `new` object, the container will create a new object for them, regardless of what's there.
      - Scoped: (in KIRSO environment) for an HTTP request
        - E.G. if we get user service, `new` is only called once for each HTTP request. The user would only create a user profile for the session once, and then it can be used for multiple subsequent requests of various data.
      - Singleton: `new` is only used first time anything tries to call the object.
  - History
    - We need a master list of object
    - We can manage lifecycle
    - We can manage dependencies
    - We can do syntax and *interface* shenanigans
- ETL: Extract Transform Load
  - Extract data for analytics
  - Do transformations
  - Put it back to DB
- EDW: Extract 
