🚀 Minimal Web API with Abstract Factory Pattern (C# / .NET 9+)
This project demonstrates how to implement the Abstract Factory design pattern using a Minimal API in .NET 6+. It exposes a single endpoint to render UI elements (Button + Checkbox) for different platforms (Windows, Mac).

🧠 About Abstract Factory Pattern
The Abstract Factory Pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.
What is Abstract Factory?
Imagine you want to create a family of related things — like furniture for a room. You want chairs, tables, and sofas, but in different styles, like Modern or Victorian.

The Abstract Factory is like a furniture store that sells complete sets.

If you choose the Modern furniture store, you get all modern chairs, tables, and sofas.

If you choose the Victorian furniture store, you get all Victorian-style furniture.

You don’t mix a Victorian chair with a modern table because they don’t match.

Key Benefits:
Promotes consistency among products

Encapsulates object creation logic

Makes it easy to switch between product families (e.g., themes, OS-specific UI)

In this project:

IGuiFactory is the abstract factory

WindowsFactory and MacFactory are concrete factories

Each factory produces a Button and a Checkbox component for its platform

Example usage
1. 🎨 UI Toolkits / Themes
Problem:
You want to support multiple themes (like light, dark, Windows, Mac) where each theme provides its own Button, Checkbox, TextField, etc.

Abstract Factory Solution:
IGuiFactory produces themed UI components.

Each theme is a concrete factory: DarkThemeFactory, LightThemeFactory.

2. 📱 Cross-Platform Apps
Problem:
Mobile or desktop apps need to use different APIs or visuals on each OS (Android, iOS, Windows).

Abstract Factory Solution:
Define a factory for each platform.

Each factory produces platform-specific components (like dialogs, notifications, gestures).

3. 🛠️ Plugin/Module Systems
Problem:
Your system supports multiple plugin types or vendor integrations that each require a set of related objects.

Abstract Factory Solution:
A plugin factory creates related objects: parsers, serializers, services.

Adding a new vendor = just adding a new factory.

4. 🧪 Testing with Mocks/Fakes
Problem:
You want to easily switch between real implementations and mock implementations (e.g., database access, API clients) for testing.

Abstract Factory Solution:
IDataFactory produces UserRepo, ProductRepo, etc.

In tests, use a MockDataFactory to produce fake services.