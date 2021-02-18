export class Triangle {
  constructor(...sides) {
    this.sides = sides;
  }

  sum(array){
   return array.reduce((acc,x)=> acc+x ,0)
  }

  splice(index){
    return this.sides.filter((x,i)=> i !== index)
  }

  numberOfDistinct(){
    return [...new Set(this.sides)].length        
  }

  isTriangleInequalityOk(){
    let xxx = this.sides.filter((side,idx)=>{
      const otherSides = this.splice(idx)
      return  this.sum(otherSides)  >= side
    })
    return xxx.length === 3
  }

  get isEquilateral() {
    if(!this.sides[0]) return false;
    return this.numberOfDistinct() === 1
    // return this.sides.reduce((acc,curr)=>  acc===curr ? acc:false ,this.sides[0]) ===this.sides[0]
    // return this.side1 == this.side2 && this.side2 == this.side3
  }

  get isIsosceles() {
    if(!this.isTriangleInequalityOk()) return false  
    return this.numberOfDistinct()  <= 2
  }

  get isScalene() {
    if(!this.isTriangleInequalityOk()) return false  
    return this.numberOfDistinct()  === 3
    }
}
