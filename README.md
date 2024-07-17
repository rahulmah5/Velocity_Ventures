# Velocity_Ventures

# Velocity Ventures EPOS System

## Overview

Welcome to the Velocity Ventures EPOS (Electronic Point of Sale) System. This Windows Forms application is designed for Velocity Ventures, a sports goods company, to manage real-time inventory and sales of various sports products. The system provides features to track inventory, record sales, and generate comprehensive reports to aid in business decision-making.

## Features

- **Real-time Inventory Tracking**: Monitor the stock levels of various sports products.
- **Sales Recording**: Record and process customer transactions efficiently.
- **Transaction Search**: Search for past transactions to analyze customer behavior.
- **Comprehensive Reporting**: Generate sales and stock reports for better business insights.

## Getting Started

### Prerequisites

- Windows Operating System
- .NET Framework

### Installation

1. Clone the repository from GitHub:
    ```sh
  https://github.com/rahulmah5/Velocity_Ventures.git
    ```
2. Open the solution file `velocityVentures.sln` in Visual Studio.
3. Build the solution to restore any missing dependencies.

### Running the Application

1. Run the application from Visual Studio by pressing `F5` or selecting `Start Debugging` from the menu.
2. The main form will appear, providing options to manage inventory, process sales, and generate reports.

## Usage

### Main Form

- **Shop Items**: Select the type and size of the sports product, and enter the quantity to add it to the cart.
- **Order Details**: View the current items in the cart and their total price.
- **Complete Order**: Finalize the purchase and update the inventory.
- **Clear**: Reset the form to its initial state.

### Sales Report

- **View Sales Report**: Opens a new form displaying the sales report, providing insights into the sales performance.

### Stock Report

- **View Stock Report**: Opens a new form displaying the current stock levels, helping in inventory management.

### Search Transactions

- **Search by Transaction ID**: Find specific transactions using their unique ID.
- **Search by Date**: Find all transactions that occurred on a specific date.

## File Structure

- **Stock.txt**: Contains the stock levels for various products.
- **Transactions.txt**: Records all the transactions processed by the system.

### Initialization

- **velocityVenturesForm_Load**: Loads the stock data from `Stock.txt` and initializes the form.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.


For any questions or support, please contact mahadevanrahul05@gmail.com

Happy selling with Velocity Ventures EPOS System!
