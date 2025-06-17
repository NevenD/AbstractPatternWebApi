# 🚀 Minimal Web API with Abstract Factory Pattern (C# / .NET 9+)
This project demonstrates how to implement the Abstract Factory design pattern using a Minimal API in .NET 9+ (compatible with .NET 6+).
It exposes a single endpoint to render UI elements (Button + Checkbox) for different platforms (Windows, Mac).

## 🧠 About Abstract Factory Pattern
The Abstract Factory Pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.

## 🔍 What is Abstract Factory?
Imagine you want to create a family of related things — like furniture for a room.
You want chairs, tables, and sofas, but in different styles, like Modern or Victorian.

The Abstract Factory is like a furniture store that sells complete sets.

If you choose the Modern furniture store, you get all modern chairs, tables, and sofas.

If you choose the Victorian furniture store, you get all Victorian-style furniture.

You don’t mix a Victorian chair with a modern table — because they don’t match.

## ✅ Key Benefits
Promotes consistency among products

Encapsulates object creation logic

Makes it easy to switch between product families (e.g., themes, OS-specific UI)

## 🧩 In This Project
IGuiFactory is the abstract factory

WindowsFactory and MacFactory are concrete factories

Each factory produces a Button and a Checkbox component for its platform

# 🧪 Example Usage of Abstract Factory
## 🎨 UI Toolkits / Themes
Problem: Support multiple themes (e.g., light, dark, Windows, Mac), each with their own UI elements.

Solution:

IGuiFactory creates themed UI components.

LightThemeFactory, DarkThemeFactory, etc., are concrete factories.

## 📱 Cross-Platform Apps
Problem: Apps need to run on Android, iOS, Windows — each with different UI APIs.

Solution:

Define a factory per platform.

Each factory produces compatible components (dialogs, notifications, gestures).

## 🛠️ Plugin / Module Systems
Problem: System supports multiple plugin types or vendors with related services.

Solution:

A plugin factory creates a related set: Parser, Serializer, Service.

New vendor? Just add a new factory.

## 🧪 Testing with Mocks / Fakes
Problem: You need to easily switch between real and mock services (e.g., for testing).

Solution:

IDataFactory produces UserRepo, ProductRepo, etc.

Use MockDataFactory in tests to create fake services.