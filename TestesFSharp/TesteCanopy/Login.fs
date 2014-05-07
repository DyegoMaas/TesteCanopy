namespace TestesMyrp

module Login =

    open canopy
    open runner
    open System

    let urlMyrp = "https://www.myrp.com.br/testar"

    //start an instance of the chrome browser
    start chrome

    let rodarTestes = fun _ ->
        "logando no Myrp" &&& fun _ ->
            url urlMyrp

        "logando no Myrp 2" &&& fun _ ->
            url "www.google.com"