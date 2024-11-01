# SwagLabs Automation Project

This project is a C# automation framework for testing the SwagLabs application using the Page Object Model (POM) design pattern. It automates key e-commerce workflows, including logging in, adding and removing products from the cart, checking out, and verifying the order completion process. The framework is structured to provide clear, maintainable code, supporting streamlined testing for SwagLabs.

## Features

- **Login Page**: Automates login functionality, verifying credentials and access control.
- **Home Page**: Adds products to the cart and removes specific items as needed to test the cart's accuracy.
- **Cart Page**: Automates navigation to the cart page, verifying the products listed and enabling checkout.
- **Checkout Process**:
  - Enters user address details.
  - Places the order and validates the success message upon order completion.
- **Logout**: Tests logging out functionality using the three-dot menu in the top-left corner to ensure secure user sessions.

## Project Structure

- **Page Objects**: Implements the Page Object Model (POM) pattern, separating each page’s UI elements and actions to maintain clean, modular code.
- **Test Cases**: Each functionality, from login to logout, is tested in isolated test cases to validate specific workflows.
- **Base Page**: Contains reusable methods and setup configurations to reduce redundancy across page objects.
  
## Usage

- **Running Tests**: Tests can be run individually or as a suite, covering the end-to-end shopping and checkout workflow in SwagLabs.
- **Results Verification**: Review the test output for success messages and session validation.
- **Logout Testing**: Ensure that session closure is functioning correctly by validating the logout button in the three-dot menu.
