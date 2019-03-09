import Entity from './entity'

export default class Product extends Entity<number>{
    code:string;
    description:string;
    brand:string;
    price:number;
}