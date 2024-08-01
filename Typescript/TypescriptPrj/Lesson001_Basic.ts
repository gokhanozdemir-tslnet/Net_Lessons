//typeescript compiler :
// npm install -g typescript
// tsc hello.ts

//1.Explicit Types 
export function great(person: string, date: Date) {
    console.log(`Hello ${person}, today is ${date.toString()}`);
}

//2.Erase Types
/*"use strict"*/
//export function great2(person, date) {
//    console.log(`Hello ${person}, today is ${date.toString()}`);
//}


//3.Primitives: sting, number and bolean
let name: string = "testname";
let intVal: number = 5;
let money: number = 500.25;

//4.Functions

export function noreturnvalfunc(param: string) {
    console.log(`Parameter is ${param}`)
}

export function retuvalfunc(param: number): number {
    return param * 2;
}

export async function promisefunc(): Promise<string> {
    return "test func json";
}

//anoyous function

//object types
export function printCoord(pt: { x: number, y: number }) {
    console.log("The cordiante's x value is" + pt.x);
    console.log("The cordiante's y values is" + pt.y);
}

//optional propertiees
export function printName(obj: { first: string; last?: string }) {

}
// Both OK
printName({ first: "Bob" });
printName({ first: "Alice", last: "Alisson" });

//union type
function printId(id: number | string) {
    if (typeof id === "string") {
        console.log("string");
    }
    else if (typeof id === "number") {
        console.log("number");
    }
}

//type aliases

type Point = {
    x: number;
    y: number;
}

export function printCoordiante(x: Point) {
    console.log("coordinate" + x);
}

//interface 
interface IPoint {
    x: number,
    y: number
}

export function printCoordiante2(x: IPoint) {
    console.log("coordiante" + x);
}

//Type assertions
const myCanvas = document.getElementById("main_canvas") as HTMLCanvasElement;
const myCanvas2 = <HTMLCanvasElement>document.getElementById("main_canvas");

function liveDangerously(x?: number | null) {
    // No error
    console.log(x!.toFixed());
}

// Creating a bigint via the BigInt function
const oneHundred: bigint = BigInt(100);

// Creating a BigInt via the literal syntax
const anotherHundred: bigint = 100n;