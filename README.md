
# Geometric shapes.

## General.

This library was written as part of a test assignment.
The main functionality is to perform operations on geometric shapes:
* create shape objects;
* calculate the possibility of creating a figure based on the parameters;
* calculate the area of a figure;
* Determine if shapes have certain properties, such as whether a triangle is a right triangle.

# Prerequisites
* The dotnet sdk package is installed (to check, just run `dotnet --help` in your console, you should get a context tip about sdk usage)

## Usage
In order to use the library, clone the repository locally.
``bash
git clone https://github.com/aleksandvladiminikol/GeometricShapes
```

Open the project folder in the terminal:
``bash
cd GeometricShapes
```

In the folder with the project, open the folder with the solution:
``bash
cd src
```

Next, choose a folder to store your local nuget packages, save that path and run it:
``zsh
dotnet pack "/Users/AnyUser/LocalNugetSource"
```

Add this path to your IDE as a new installation source for nuget packages, search for and install the package.

## Contribution.
For a new contribution to the library, use the suggested design. Inherit from an abstract class and implement its methods. Don't forget to increment the version. If you need to use different versions at the same time, design and implement a CICD configuration for your package and publish it in one of the popular sources, like nuget.org, or in your secure domain (like Azure or Jfrog).
