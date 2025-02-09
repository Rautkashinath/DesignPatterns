# DesignPatterns
Implementation of design patterns using C#

Creational Design Patterns:
Provides various object creation mechanism which increase flexiblity and reuse of existing code

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



Structural Design Patterns:
Explains how to assemble objects and classes into larger structures while keeping these structures flexible and efficient.

1. Adapter
    - Interface
    - Adapter (must follow client interface)
    - Adaptee (legacy or TPL adaptee)
    - Client

2. Bridge
    - Abstraction (control layer)
    - Implementation (implementation to do real work)
    - Client (provide implementation object to abstraction and get work done through abstraction only)

3. Composite
    - Component (Interface)
    - Composite (Provides way to add and remove component and implement component(interface) method)
    - Leaf (does the real work)
    - Client

4. Decorator
    - Abstract Component
    - Concrete Component (default implementation)
    - Base Decorator (wrapping interface for concrete decorators)
    - Concrete Decorators
    
5. Facade
    - TPL, Framework, Subsystems
    - Facade
    - Client
