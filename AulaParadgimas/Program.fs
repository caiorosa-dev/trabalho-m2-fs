open System


// ----------------------------
//           Utils
// ----------------------------

let readInt(message) =
    printfn message
    let input = Console.ReadLine()
    Int32.Parse(input)

let readFloat(message) =
    printfn message
    let input = Console.ReadLine()
    float input

let wait() =
    Console.ReadLine() |> ignore

// ----------------------------
//           Exercicios
// ----------------------------

let divide (firstNumber: float) (secondNumber: float) =
    if (firstNumber > secondNumber) then
        firstNumber / secondNumber
    else
        secondNumber / firstNumber

let exerciseOne() = 
    let firstNumber = readFloat("Número 1 (float): ")
    let secondNumber = readFloat("Número 2 (float): ")

    let result = divide firstNumber secondNumber

    Console.Clear()

    printf "\n * O resultado da operação entre %f e %f é: %f" firstNumber secondNumber result

// ----------------------------
//             Menu
// ----------------------------

let rec menu () =
    Console.Clear()
    printf "\n"
    printf " - Olá! Bem vindo ao Trabalho 1 da M2\n"
    printf " * Digite qual número do menu você deseja ir\n"
    printf "\n"
    printf " (0) - Sair\n"
    printf " (1) - Exercício 1\n"
    printf " (2) - Exercício 2\n"
    printf " (3) - Exercício 3\n"
    printf "\n"

    let option = readInt("Insira a opção desejada: \n")

    if (option >= 0 && option <= 3) then
        Console.Clear()

        if (option = 0) then
            printf "\nTrabalho feito por: Caio Furtado Rosa. Até!\n"
        else if (option = 1) then
            printf "\n Exercício 1 escolhido. \nForneça 2 números para realizar a divisão:\n\n"
            
            exerciseOne()

            printf "\n\n Para continuar aperte ENTER."
            
            wait()
            menu()
        else if (option = 2) then
            printf "Opção 2"

            menu()
        else
            printf "Opção 3"

            menu()
    else
        printf "Valor invalido"
        menu()

// ----------------------------
//         Entry Point
// ----------------------------

menu()