# Moon Core Technical Stack

## Philosophy

Every technology used by Moon Core should have a clear purpose.

The technical stack is chosen based on long-term maintainability, performance and Windows integration rather than developer familiarity.

Technology decisions should always prioritize the project's architecture over personal preference.

---

## Programming Language

### C#

Moon Core is primarily developed using C# and the .NET platform.

Why?

- Native Windows ecosystem
- Excellent .NET ecosystem
- Great desktop application support
- High performance
- Easy distribution
- Long-term maintainability
- Strong tooling and documentation

---

## Language Evaluation

Before selecting the core language, multiple technologies were evaluated.

### Python

**Strengths**

- Rapid development
- Excellent AI ecosystem
- Great automation support
- Large community

**Limitations**

- Less suitable for large Windows desktop applications
- Distribution and deployment are more complex
- Desktop frameworks are less integrated with Windows

---

### Rust

**Strengths**

- Outstanding performance
- Memory safety
- Small executables
- Modern systems programming language

**Limitations**

- Steep learning curve
- Slower development speed for a project of this scope
- Smaller desktop ecosystem

---

### C#

C# was selected as the core language because it provides the best balance between:

- Native Windows integration
- Performance
- Desktop development
- Long-term maintainability
- Mature .NET ecosystem
- Excellent developer experience

---

## Runtime

Moon Core targets the latest supported .NET Long-Term Support (LTS) release.

Why?

- Long-term support
- Modern APIs
- Excellent Windows integration
- Continuous performance improvements

---

## Configuration Files

### JSON

Why?

- Human-readable
- Easy to edit
- Native .NET support
- Simple serialization and deserialization

---

## Logging

### Microsoft.Extensions.Logging

Why?

- Standard .NET logging solution
- Easy to extend
- Multiple logging providers
- Consistent logging architecture

---

## Architecture

Moon Core follows a modular architecture.

Each module has a single responsibility and communicates through well-defined interfaces.

Examples of core modules include:

- Workspace Manager
- Widget Manager
- Configuration Manager
- Sidebar
- CLI
- Integration Layer

---

## Development Tools

The project is developed using the standard .NET ecosystem.

Current development tools include:

- .NET SDK
- Visual Studio Code
- Git
- GitHub

Additional tools may be adopted as the project evolves.

---

## Future Components

Moon Core is designed to integrate with independent services without creating direct dependencies.

Example:

Neva AI (Python)

Possible communication methods include:

- HTTP API
- Named Pipes
- Local IPC

Moon Core remains independent from AI implementations.

---

## Artificial Intelligence

Moon Core itself does not implement AI features.

Artificial intelligence will be provided through independent modules.

The first planned AI integration is **Neva**, a desktop AI assistant developed independently from Moon Core.

Neva will be implemented in Python and communicate with Moon Core through well-defined interfaces.

This separation keeps the core engine modular, maintainable and independent from AI technologies.

It also allows the AI implementation to evolve independently without requiring changes to the Moon Core engine.

---

## Future Revisions

The technical stack is expected to evolve over time.

Technology choices may change if they provide clear architectural, performance or maintainability benefits.

Any significant change should be documented before implementation.