//Part 1 
function checkType(input){
    console.log("John",42,false,undefined)
}
checkType()
let input=prompt("What is the type")
checkType=(input)

//Part 2
function calculateDogAge(humanYears){
    let dogYears=humanYears*7
    return dogYears
}
console.log(calculateDogAge(5))

//Part 2 bonus
function calculateHumanAge(dogYears){
    let humanYears=dogYears/7
    return humanYears
}
console.log(calculateHumanAge(42))

//Part 3
function withdrawCash(){
    let accountBalance=3000
    let amountRequested=prompt("Enter the amount you want to withdraw")
    let amount=parseFloat(amountRequested)
    if (amount>accountBalance){
        return "Not enough money"
    }
    if (amount<accountBalance) {
        return "Withdraw successful"
    }
}
console.log(withdrawCash())
//Ne znam kako da napravam da dade amount left ako e 
//withdraw successful
    