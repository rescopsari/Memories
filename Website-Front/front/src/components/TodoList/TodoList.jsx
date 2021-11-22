import React, { useState } from "react";
import "./todoList.css";


const TodoList = () => {
  const [dataTodo,setDataTodo] = useState({
    title:"",
    date:"",
    description:""
  })


  const handleChange = (e) => {
      const { name , value } = e.target
      setDataTodo({...dataTodo , [name] : value})
  }

  const handleSubmit = (e) => {
    e.preventDefault()
    console.log(dataTodo)
  }


 return(
   <div className="todolist">
     <form onSubmit={handleSubmit} action="" className="todo__form">
       <label htmlFor="text" className="todo__label" >Titre:</label>
       <input name="title" className="todo__input"  onChange={handleChange}/>
       <label htmlFor="text" className="todo__label">Description:</label>
       <textarea  name="description" className="todo__input" onChange={handleChange} />
       <label htmlFor="text" className="todo__label">Date:</label>
       <input type="date" name="date" className="todo__input" onChange={handleChange}/>

       <button type="submit"  className="todo__button" >Enregistrer </button>
       
     </form>
   </div>
 )
}
export default TodoList;
