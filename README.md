# DesignPatterns
Implementation of design patterns using C#

Creational Design Patterns:

1. Factory Method
    - Abtract Factory
    - Concrete Factory
    - Abstract Product
    - Concrete Product
    - Client will call concrete factory to get abstract product but that will return concrete product based on factory

2. Abstract Factory
    - Abstract Factory
    - Concrete Factory
    - Abstract Products
    - Concrete Products
    - Client will set of related products from concrete factory

3. Builder
    - Director will guide the builder to create the object with required features.

4. Prototype
    - Prototype Interface
    - Concrete Prototype
    - Concrete Prototype will provide Clone method to provide clone of it's object.

5. Singleton
    - Simple
    - Thread Safe
    - Thread Safe with Double Lock Check
    - Lazy with Static Constructor (To Ensure fields are initialzed before they are accessed)
    - Fully Lazy with Nested Class
    - Using DotNet Lazy Class type