# SingletonVsStaticBenchmark

Welcome to the **SingletonVsStaticBenchmark** repository! 🚀 This project explores the performance and use cases of **Singleton** and **Static** classes through comprehensive benchmarking.

---

## 📋 Overview

Singletons and static classes are widely used patterns for managing shared resources. While they often seem interchangeable, their performance and functionality differ significantly depending on the context. This repository provides:

- Detailed performance benchmarks using **BenchmarkDotNet**
- Analysis of **thread safety**, **memory usage**, and **initialization costs**
- Scenarios involving:
  - Static access
  - Lightweight Singleton initialization
  - Heavy Singleton initialization
  - Multi-threaded Singleton access

---

## 🛠️ How to Run

### Prerequisites

- .NET 8.0 SDK or later
- Visual Studio or any C# IDE

### Steps

1. Clone the repository:
   ```bash
   git clone https://github.com/your-repo-link-here
   ```

2. Navigate to the project directory:
   ```bash
   cd SingletonVsStaticBenchmark
   ```

3. Restore dependencies:
   ```bash
   dotnet restore
   ```

4. Run the benchmarks:
   ```bash
   dotnet run -c Release
   ```

---

## 📚 When to Use

- **Static**: Perfect for utilities, constants, and lightweight operations that don’t require instance management.
- **Singleton**: Best suited for shared resources that need controlled initialization, lazy loading, or thread safety.

---

## 🤝 Contributing

Contributions are welcome! 🎉 If you’d like to improve this project, follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Commit your changes with a clear message.
4. Push your branch and open a pull request.

---

## 📄 License

This project is licensed under the MIT License. Feel free to use, modify, and share the code.

---

## ✨ Feedback

Have ideas or suggestions? Open an issue or contact us directly. Let’s collaborate and make this project even better! 🌟

---

Happy benchmarking and coding! 🚀
