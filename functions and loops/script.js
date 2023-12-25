//PART 1-Function tellStory
function tellStory([name, mood, activity]) {
    let story = `This is ${name}.${name} is a nice person.
Today they are ${mood}.They are ${activity} all day.The end.`
    return story
}
let storyArray = ["Bazhe", "happy", "gaming"]
let result = tellStory(storyArray)
console.log(result)

//PART 2-Function that will take an array of 5 numbers
function calculateSum(numbers) {
    let sum = 0
    for (let i = 0; i < numbers.length; i++) {
        sum += numbers[i];
    }
    return sum
}
let numbersArray = [7, 11, 15, 21, 25];
let result2 = calculateSum(numbersArray)
console.log(result2)


//PART 3-function one big string
function concatanateStrings(array) {
    let result3 = ""
    for (let i = 0; i < array.length; i++) {
        result3 += array[i] + " "
    }
    return result3
}
let stringArray = ["Hello", "there", "students", "of", "SEDC"]
let result3 = concatanateStrings(stringArray)
console.log(result3)


