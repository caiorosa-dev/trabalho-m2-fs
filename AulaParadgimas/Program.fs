open System


// ----------------------------
//           Utils
// ----------------------------

let readInt(message) =
    printfn "%s" message
    Console.ReadLine() |> Int32.Parse

let readFloat(message) =
    let formattedMessage = " [>] " + message + " (float):"

    printfn "%s" formattedMessage
    Console.ReadLine() |> float

let wait() =
    Console.ReadLine() |> ignore

// ----------------------------
//           Exercicios
// ----------------------------

let exerciseOne() = 
    // Função para realizar a divisão dos números
    let divide (firstNumber: float) (secondNumber: float) =
        if (firstNumber > secondNumber) then
            firstNumber / secondNumber
        else
            secondNumber / firstNumber
            
    // Leitura dos dados e resposta ao usuário
    let firstNumber = readFloat("Número 1")
    let secondNumber = readFloat("Número 2")

    let result = divide firstNumber secondNumber

    printf "\n [*] O resultado da operação entre %f e %f é: %f" firstNumber secondNumber result

let exerciseTwo() =
    // Função para verificar se as medidas dos lados são válidas
    let isTriangle (sideOne: float) (sideTwo: float) (sideThree: float) =
        let firstTest = sideOne > (sideTwo + sideThree)
        let secondTest = sideTwo > (sideOne + sideThree)
        let thirdTest = sideThree > (sideOne + sideTwo)

        (not firstTest) && (not secondTest) && (not thirdTest)

    // Função para verificar se é equilátero
    let isAllSidesEqual (sideOne: float) (sideTwo: float) (sideThree: float) =
        (sideOne = sideTwo) && (sideOne = sideThree)

    // Função para verificar se é isósceles
    let isIsosceles (sideOne: float) (sideTwo: float) (sideThree: float) =
        (sideOne = sideTwo) || (sideOne = sideThree) || (sideTwo = sideThree)

    // Função para verificar se é escaleno
    let isScalene (sideOne: float) (sideTwo: float) (sideThree: float) =
        not (sideOne = sideTwo) && not (sideOne = sideThree) && not (sideTwo = sideThree)

    let firstNumber = readFloat("Lado 1")
    let secondNumber = readFloat("Lado 2")
    let thirdNumber = readFloat("Lado 3")

    printf "\n"
    if (not (isTriangle firstNumber secondNumber thirdNumber)) then
        printf " [x] - As medidas escolhidas para os lados do triângulo são inválidas."
    else
        if (isAllSidesEqual firstNumber secondNumber thirdNumber) then
            printf " [*] O triângulo é Equilátero."
        else if (isIsosceles firstNumber secondNumber thirdNumber) then
            printf " [*] O triângulo é Isósceles."
        else if (isScalene firstNumber secondNumber thirdNumber) then
            printf " [*] O triângulo é Escaleno."
        else
            printf " [*] Nenhuma conclusão pode ser tomada."

let exerciseThree() =
    let array = [0..20]

    printf " [#] Vetor Inicial: %A" array

    // Realização das operações
    let result =  array |> List.filter (fun n -> (n % 2) = 0) |> List.map (fun n -> n * 2) |> List.filter (fun n -> (n % 6) = 0)

    printf "\n\n [*] Vetor Final: %A" result


let exerciseFour() =
    let readInputsAndGetGrade =
        let firstNumber = readFloat("Nota 1")
        let secondNumber = readFloat("Nota 2")
        let thirdNumber = readFloat("Nota 3")

        (firstNumber + secondNumber + thirdNumber) / 3.0

    let isStudentApproved (grade: float) = 
        grade >= 6.0

    let printMessage (isApproved: bool) =
        printf "\n"
        if (isApproved) then
            printf " [*] - O aluno foi aprovado :)"
        else
            printf " [x] - O aluno não foi aprovado :("

    readInputsAndGetGrade |> isStudentApproved |> printMessage

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
    printf " (4) - Exercício 4\n"
    printf "\n"

    let option = readInt(" [>] Insira a opção desejada: \n")

    Console.Clear()
    if (option >= 0 && option <= 4) then
        if (option = 0) then
            printf "\n [*] Trabalho feito por: Caio Furtado Rosa."
            printf "\n - Website: https://caiorosadev.com"
            printf "\n - Repositório: https://github.com/caiorosa-dev/trabalho-m2-fs"
            printf "\n\n [-] Aperte ENTER para fechar o programa."

            wait()
            exit 0
        else if (option = 1) then
            printf "\n - Exercício 1 escolhido. \n * Forneça 2 números para realizar a divisão:\n\n"
            
            exerciseOne()
        else if (option = 2) then
            printf "\n - Exercício 2 escolhido. \n * Forneça 3 números para realizar a operação:\n\n"
            
            exerciseTwo()
        else if (option = 3) then
            printf "\n - Exercício 3 escolhido.\n\n"
            
            exerciseThree()
        else
            printf "\n - Exercício 4 escolhido. \n * Forneça 3 números para calcular a média:\n\n"
            
            exerciseFour()
        printf "\n\n Para continuar aperte ENTER."
            
        wait()
        menu()
    else
        printf " [x] Opção inválida. Tente novamente após apertar ENTER."
        wait()
        menu()

// ----------------------------
//         Entry Point
// ----------------------------

menu()