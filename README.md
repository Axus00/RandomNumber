# RandomNumber
Repositorio para Nuget de generar número aleatorio


# RandomNumber

RandomNumber es una biblioteca para generar números aleatorios de 4 dígitos. Útil para aplicaciones que necesiten autenticación basada en códigos, identificadores temporales, etc.

## Instalación

Puedes instalar el paquete mediante NuGet:

```csharp
dontet add package RandomNumberGenerator

## Uso

Aquí tienes un ejemplo de cómo generar un número aleatorio de 4 dígitos:

```csharp
using RandomNumber;

int randomNumber = GenerateRandomNumber.GenerateNumber();
Console.WriteLine("Número aleatorio de 4 dígitos: " + randomNumber);
