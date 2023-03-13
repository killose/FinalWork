function getLength(){
    return +prompt("Введите колличество значений в массиве")
  }
  
  function getArray(leng){
    let arr = []
    for (let i = 0; i < leng; i++) {
      arr[i] = prompt("Задайте элемент массива" +i)
    }
    return arr
  }
  
  let startArray = getArray(getLength())
  let createArray = (arr) => {
      let filterArray = []
      for (let i = 0; i < arr.length; i++) {
        if (arr[i].length <= 3) {
          filterArray.push(arr[i]);
        }
      }
      return filterArray
  }
  
  const showArray = (arr) => {
      return console.log(`Отфильтрованный, результативный массив`), console.log(arr);
  }
  
  showArray(createArray(startArray));