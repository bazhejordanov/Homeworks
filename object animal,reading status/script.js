//Part 1
function Animal(name,kind){
this.name=name
this.kind=kind
this.speak=function (message){
    console.log(`${this.kind} ${this.name} says '${message}'`)
}
}
let dog=new Animal("Leo", "Dog")
dog.speak("Hey bro!!!")

//Part 2
function Book(title,author,readingStatus){
    this.title=title
    this.author=author
    this.readingStatus=readingStatus
    this.Info=function(){
        if(this.readingStatus){
            return `Already read '${this.title}' by'${this.author}'`
        }else{
            return `You still need to read '${this.title} by'${this.author}'`
        }
    }
}

let book1=new Book("The Robots of Dawn","Isaac Asimov",true)
let book2=new Book("Mockingjay:The Final Book of The Hunger Games","Suzanne Collins",false)

console.log(book1.Info())
console.log(book2.Info())
