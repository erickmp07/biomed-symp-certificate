# biomed-symp-certificate

A [.NET](https://dotnet.microsoft.com/) app to generate a list of subscribers of a symposium that have signed a given number of attendance lists.

This project was created with the aim of help a symposium organizing committee to fast check the subscribers who attended the minimum number of lectures.

## Table of Contents

- [Install](#install)
- [Usage](#usage)
- [Thanks](#thanks)
- [Technologies](#technologies)
- [Contributing](#contributing)
- [License](#license)

## Install

- Download a stable [Release](https://github.com/erickmp07/biomed-symp-certificate/releases).

- Extract the folder.

- Open the `BiomedSympCertificate.exe` file.

## Usage

First, set the minimum number of lectures a subscriber should have signed the list. Then, click on the button to select the spreadsheets files to import.

The extensions supported are: *.xls; *.xlsx

The spreadsheets should have the following format:

- Four columns;
- First line is the column header;
- First column has a Datetime format (sign datetime);
- Second column has a string format (name);
- Third column has a string format (e-mail);
- Fourth column has a string format (registration number).

The output file will be available at the same directory of the spreadsheets imported.

## Thanks

To Thayane Santos Silva, for the inspiration for this project and the time spent answering my questions.

## Technologies

This project was developed with the following technologies:

- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)
- [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
- [EPPlus](https://github.com/JanKallman/EPPlus)
- [ExcelDataReader](https://github.com/ExcelDataReader/ExcelDataReader)
- [DryIoc](https://github.com/dadhi/DryIoc)

## Contributing

PRs and stars are always welcome.

To ask a question, please [contact me](mailto:erimacedo_92@hotmail.com).

## License

Licensed under [MIT](LICENSE) license.