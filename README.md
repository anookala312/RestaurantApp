# RestaurantApp - README

## Project Overview

This is the README file for the RestaurantApp project, a mobile and desktop application built with .NET MAUI.

The RestaurantApp is a basic example to showcase the functionalities of .NET MAUI. It allows users to:

- Login to an account
- Signup for a new account
- Navigate between Login, Signup, and Home Pages (using NavigationPage)

## Project Structure

The project consists of the following folders and files:

- **App.xaml.cs:** Defines the main application and sets the MainPage as a NavigationPage containing the MainPage itself.
- **MainPage:** Contains the UI for the Login screen with username, password fields, and Login/Register buttons. (MainPage.xaml & MainPage.xaml.cs)
- **SignupPage:** Contains the UI for the Signup screen with email, password fields, and a Register button. (SignupPage.xaml & SignupPage.xaml.cs)
- **Models:** Currently empty, but could hold classes for User data etc.
- **ViewModels:**
  - **LoginPageViewModel:** Handles Login and Register button clicks and pushes the corresponding pages using Navigation.
  - **SignupPageViewModel:** Currently a placeholder with no implemented functionality.

### Explanation of Code

- **App.xaml.cs:** Initializes the application and sets the MainPage as the starting point of the app using a NavigationPage for navigation.
- **MainPage.xaml:** Defines the login interface with fields for username and password, and buttons for login and registration. It uses a grid and stack layout for organizing UI elements.
- **MainPage.xaml.cs:** Sets the BindingContext to `LoginPageViewModel`, which contains the logic for handling login and registration actions.
- **SignupPage.xaml:** Defines the registration interface with fields for email and password, and a button for registration. It uses a similar layout structure to the MainPage.
- **SignupPage.xaml.cs:** Sets the BindingContext to `SignupPageViewModel`, which will handle the logic for user registration.
- **LoginPageViewModel:** Contains commands for handling the login and register button clicks, and navigates to the appropriate pages.
- **SignupPageViewModel:** Contains a placeholder for the registration functionality, with a command to handle the register button click.

## Using Git Features

This project utilizes Git for version control. We plan to utilize features like branching and merging for future development:

- **Branching:** We might create separate branches for feature development and bug fixes.
- **Merging:** Merging these branches back into the main branch will integrate the new features and bug fixes.

### Current Git Workflow

- **Main Branch:** Contains the stable codebase.
- **Feature Branches:** Separate branches created for developing new features.
- **Merging:** Feature branches are merged back into the main branch after testing and review.

## Getting Started (Future Implementation)

This section will be filled in the future with instructions on how to run the application and contribute to the project.

## Next Steps

- Implement user login and signup functionality with proper data storage (e.g., database).
- Develop screens for browsing the restaurant menu and adding items to a cart.
- Implement a checkout process for payment (placeholder functionality for now).
- Style the application with a restaurant theme.

This README file will be updated as the project progresses.
---

*This README file will evolve as the project progresses. Stay tuned for more updates and improvements!*
