# Moon Core Architecture

## Overview

Moon Core is built around a modular architecture.

Each component has a single responsibility and can work independently while integrating with the rest of the system.

This architecture allows users to customize their workspace without depending on a single application or technology.

---

## High-Level Architecture

```text
                    Moon Core
                         │
        ┌────────────────┼────────────────┐
        │                │                │
 Workspace Manager  Configuration Manager Integration Layer
        │
        │
 Widget Manager
        │
        │
     Sidebar
        │
        │
       CLI

Integration Layer
 ├── Rainmeter
 ├── Flow Launcher
 └── Everything
```

The diagram above represents the high-level architecture of Moon Core.

Each module has a single responsibility and communicates with the others through well-defined interfaces.

---

## Core Modules

Moon Core is composed of independent modules.

Each module is responsible for one part of the workspace experience.

The main modules are:

- Workspace Manager
- Widget Manager
- Configuration Manager
- Sidebar
- CLI
- Integration Layer

---

## Workspace Manager

The Workspace Manager is responsible for managing workspace profiles.

A workspace defines which widgets, shortcuts, layouts and settings should be active for a specific scenario, such as Development, Study or Gaming.

Users can switch workspaces through the CLI or the graphical interface.

---

## Widget Manager

The Widget Manager controls the lifecycle of every widget.

It is responsible for enabling, disabling, configuring and updating widgets without affecting the rest of the workspace.

---

## Configuration Manager

The Configuration Manager stores and loads user preferences.

It keeps all configuration files organized and ensures that every module can access the information it needs.

---

## Sidebar

The Sidebar provides quick access to the most important workspace actions.

It allows users to launch applications, switch workspaces, control widgets and access power options from a single location.

---

## CLI

The Command Line Interface (CLI) allows users to control Moon Core using simple commands.

The CLI provides a fast way to switch workspaces, manage widgets and configure the system.

---

## Integration Layer

The Integration Layer is responsible for communicating with third-party applications.

It provides a unified interface between Moon Core and external tools without exposing their internal implementation to the rest of the system.

Current integrations include:

- Rainmeter
- Flow Launcher
- Everything

Future integrations can be added without changing the core architecture.

---

## Future Modules

Moon Core is designed to grow over time.

Future modules should follow the same architectural principles as the existing modules.

Each new module must remain independent, modular and easily replaceable.

Possible future modules include:

- Neva AI Assistant
- Plugin Manager
- Theme Manager
- Profile Manager
- Package Manager
- Update Manager
- Logging Manager
- Cloud Synchronization