<div align="center">
<a href="https://dot.net"><img src="https://github.com/dotnet.png" width="100"></a>
</div>

<h1 align="center">.NET Clean Architecture</h1>

- **Domain Layer:** Contains the business entities and rules that govern the behavior of the system. This layer is independent of any frameworks or libraries.

- **Application Layer:** Manages application logic, orchestrating data flow between layers and handling use case execution. It can also include interfaces to external services.

- **Infrastructure Layer:** Implements the interfaces defined in the application layer, dealing with data persistence, third-party services and other implementation details. This is where you can find repository implementations, database access, and service configuration.

- **Presentation Layer:** Responsible for interaction with the user, whether through an API, a web application or a graphical interface. This layer uses the application layer to execute the use cases.

## Credits
- [.NET - Using Clean Architecture - I](https://www.youtube.com/watch?v=luyGoZa9is4)
- [.NET - Using Clean Architecture - II](https://www.youtube.com/watch?v=K8sH-CQ23bs)
- [.NET - Using Clean Architecture - III](https://www.youtube.com/watch?v=vrTHV53McQM)
- [.NET - Using Clean Architecture - IV](https://www.youtube.com/watch?v=GSMjpYuYK-Q)
- [.NET - Using Clean Architecture - V](https://www.youtube.com/watch?v=G2vXO4X_hEk)
