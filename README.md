# Application Name

## Application Description

This application is designed to validate a given string based on specific criteria, including length, character types, and whitespace handling. Utilizing a regular expression, the application ensures that the string meets the requirements of containing at least one uppercase letter, one lowercase letter, one digit, one special character from a predefined list, and no whitespace characters. It's an essential tool for input validation, making it suitable for contexts such as password validation and data integrity checks.

## Regex Implementation Description

The implemented regex in this application performs multiple validations on a given string. It first checks the maximum string length, as defined by a parameter, ensuring flexibility in usage. The expression enforces the presence of at least one uppercase letter, one lowercase letter, one digit, and one special character from a predefined set of characters !"#$%&'()*+,-./:;<=>?@[\\]^_\{|}~`. It strictly disallows any whitespace characters, including spaces, tabs, or newlines. The construction is optimized for execution speed and simplicity, utilizing non-capturing groups and other techniques to enhance efficiency. Encapsulated within a function, it ensures reusability across the application. Robust unit tests confirm its proper function across various scenarios. Thoughtful documentation and comments explain its design and behavior. Graceful error handling is also incorporated, providing robustness in diverse scenarios. Overall, the regex serves as a versatile and powerful validation tool within the application.

## Running the Application Locally

1. **Clone the Repository**: Clone the application repository to your local machine using Git.
   ```bash
   git clone https://github.com/bhelga/regex-case-10.git
2. **Navigate to the Project Directory**: Navigate to the directory containing the solution file.
	```bash
	cd your folder\regex-case-10\Case-10\Case-10.sln
3. **Build the Solution**: Build the solution using the dotnet CLI.
	```bash
	dotnet build
4. **Run the Application**: Run the application using the following command:
	```bash
	dotnet run --project your folder\regex-case-10\Case-10\Case-10.csproj
5. **Run the Tests**: If you wish to run the unit tests, use the following command:
	```bash
	dotnet test your folder\regex-case-10\RegexValidatorTests\RegexValidatorTests.csproj

