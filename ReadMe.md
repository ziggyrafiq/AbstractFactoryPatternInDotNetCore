# AbstractFactoryPatternInDotNetCore

This repository demonstrates the implementation of the Abstract Factory Design Pattern using .NET Core and C# 12. With the Abstract Factory pattern, families of related or dependent objects can be created without specifying their concrete classes, which ensures loose coupling and flexibility in software development.

 **[Article published on C# Corner click here to read this article](https://www.c-sharpcorner.com/article/abstract-factory-design-pattern-in-net-core-c-sharp-12/)**

## Components

- **AbstractFactory:** Defines methods for creating abstract products.
- **ConcreteFactoryA/B:** Implements the creation methods to produce concrete products.
- **AbstractProduct:** Interface for product types.
- **ConcreteProductA1/A2 & B1/B2:** Concrete implementations of abstract products.
- **Client:** Uses the abstract factory to create and use products.

## Usage

To run the example:

1. Clone this repository.
2. Navigate to the `src/AbstractFactoryPattern` directory.
3. Run the application with `dotnet run`.

## Files

- **IAbstractFactory.cs:** Defines the factory interface.
- **ConcreteFactoryA.cs / ConcreteFactoryB.cs:** Implementations of the factory.
- **IAbstractProductA.cs / IAbstractProductB.cs:** Interfaces for the products.
- **ConcreteProductA1.cs / ConcreteProductA2.cs / ConcreteProductB1.cs / ConcreteProductB2.cs:** Concrete product implementations.
- **Client.cs:** Client class that uses the factory.
- **Program.cs:** Entry point of the application.

## About The Author Ziggy Rafiq

Ziggy Rafiq works as a Technical Lead Developer and is a prominent public figure in the tech industry and developer community. With over 20 years of experience as a Full-Stack Designer, Developer, Tester, DevSecOps, Technical Architect,
Software Project Manager, and expert in Agile Management Best Practices and Standards, Ziggy is widely respected for his knowledge and skills. He is also an author, regularly contributing articles
to [C# Corner](https://www.c-sharpcorner.com/members/ziggy-rafiq), and [Geek Coding](https://geek-coding.com/members/ziggy-rafiq) to
share his expertise and wisdom with a global audience. Ziggy also has a YouTube Channel where he creates content based on his experience to help and inspire other developers, designers, testers, project managers,
technical architects, and Agile Scrum masters.

- **Technical Lead Developer, Mentor and Trainer**
- **[C# Corner (MVP 🏅, VIP⭐️, Public Speaker🎤)](https://www.c-sharpcorner.com/members/ziggy-rafiq)**
- **[Geek Coding Writter](https://geek-coding.com/members/ziggy-rafiq)**
- **[Technology Manager Writter](https://technology-manager.com/members/ziggy-rafiq)**
- Link to [**Ziggy Rafiq Blog**](https://blog.ziggyrafiq.com)
- Link to [**Ziggy Rafiq Website**](https://ziggyrafiq.com)

* [**Please remember to subscribe to My YouTube channel**](https://www.youtube.com/)
* [**Please remember to follow me on LinkedIn**](https://www.linkedin.com/in/ziggyrafiq/)
* [**Please remember to follow me on Twitter/X**](https://twitter.com/ziggyrafiq)
* [**Please remember to follow me on Instagram**](https://www.instagram.com/ziggyrafiq/)
* [**Please remember to follow me on Facebook**](https://www.facebook.com/ziggyrafiq)

## Contributing

Any improvements or corrections should be submitted as a pull request or opened in an issue.

## License

The LICENSE file contains details about how this project is licensed under the MIT License.
