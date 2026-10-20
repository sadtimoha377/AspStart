import { useState } from 'react'

const App = () => {
  const [count, setCount] = useState(0)

  return (
    <div>
      <h1>React bundle on ASP.NET</h1>
      <hr />
      <p>Counter: {count}</p>
      <button onClick={() => setCount(count + 1)}>Press it!</button>
    </div>
  )
}

export default App
