# Process Insight Tool

## Overview
Process Insight Tool is a WPF-based desktop application that provides deep insights into the running processes on a machine. It offers real-time tracking of processes, network traffic, process trees, remote IP connections, packet dissection, and more. The application is designed using the **MVVM (Model-View-ViewModel)** architecture, ensuring clean code separation and easy maintainability.

## Table of Contents
- [Features](#features)
- [Architecture](#architecture)
- [Commands Overview](#commands-overview)
- [ViewModels Overview](#viewmodels-overview)
- [TCPProcess Class](#tcpprocess-class)
- [Navigation Service](#navigation-service)
- [NetstatOutputHelper](#netstatoutputhelper)
- [Installation](#installation)
- [Usage](#usage)
- [License](#license)

## Features
- Real-time monitoring of running processes
- Displays detailed process information (Process ID, Name, IP, Port, Status)
- Packet dissection
- Process navigation and tracking using commands
- Process tree visualization with root process identification
- Remote IP traffic analysis
- Integrated with **netstat** for gathering network-related process data
- Clean architecture using MVVM for better maintainability

## Architecture
This project follows the **MVVM** design pattern to separate concerns between the UI and business logic, making the app scalable and maintainable. The following folders are key components:

### **Commands**
This folder contains command classes derived from `CommandBase` which implement the `ICommand` interface, handling user interactions.

### **ViewModels**
The `ViewModelBase` class is the base class for all view models in this project, implementing the `INotifyPropertyChanged` interface to notify the UI of any property changes. Each ViewModel is responsible for the presentation logic.

### **Services**
The `NavigationService` and `ParameterNavigationService` classes handle navigation between different views in the application.

## Commands Overview
The project implements several commands to handle process navigation, refresh, details display, and closing windows. Some of the key commands include:

- **DetailsCommand**: Opens a new window to display the details of a selected process.
- **MoveCommand**: Moves to the next or previous process in the list.
- **NavigateAnalysisCommand**: Navigates to a detailed analysis view if there are associated processes.
- **RefreshCommand**: Refreshes the list of active TCP processes by calling `NetstatOutputHelper`.
- **ClearCommand**: Clears the list of active processes.

For more detailed information about these commands, see the [Commands Overview](#commands-overview) section.

## ViewModels Overview
This section explains the key ViewModel classes:

### **HomeViewModel**
Handles the main window of the application, which displays a list of active TCP processes. It includes commands to refresh, clear, and display detailed process information.

### **ParticularProcessViewModel**
Displays the details of a specific process and allows navigation through related processes. This ViewModel supports moving to the next or previous process, displaying associated processes, and navigating to the analysis view.

### **MainViewModel**
Manages the current view in the main window using the `NavigationStore`.

For more detailed information about the ViewModels, visit the [ViewModels Overview](#viewmodels-overview).

## TCPProcess Class
The `TCPProcess` class represents the details of a running process, including:
- **ProcessName**: Name of the process.
- **ProcessID**: Unique identifier for the process.
- **Protocol**: Communication protocol (e.g., TCP).
- **LocalIP**: Local IP address.
- **LocalPort**: Local port number.
- **RemoteIP**: Remote IP address the process is communicating with.
- **RemotePort**: Remote port number.
- **Status**: Connection status (e.g., listening, established).

For more details, check out the [TCPProcess Class](#tcpprocess-class) section.

## Navigation Service
The `NavigationService` and `ParameterNavigationService` classes are responsible for navigating between different views in the application.

### NavigationService
Handles navigation between views that do not require parameters.

### ParameterNavigationService
Handles navigation between views that require parameters for initialization.

For implementation details, visit the [Navigation Service](#navigation-service) section.

## NetstatOutputHelper
`NetstatOutputHelper` is responsible for gathering network process data by running the `netstat` command with the appropriate arguments. It processes the output to extract useful information about active TCP connections.

## Installation

To set up this project locally, follow the steps below:

  1. Clone the repository: git clone https://github.com/abdeloow/ProcessDissect.git
  2. Open the project in Visual Studio.
  3. Open the project in Visual Studio.

## Usage

To use the Process Insight Tool:

  1. Launch the application.
  2. You will see the main window displaying the list of active TCP processes.
  3. You can refresh the list, clear it, or view detailed information about each process by clicking the corresponding buttons.

## License
This project is licensed under the MIT License.
