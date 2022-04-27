import './App.css';
import {Home} from '../../react-app/src/Home';
import {Department} from '../../react-app/src/Department';
import {Employee} from '../../react-app/src/Employee';
import {Navigation} from '../../react-app/src/Navigation';
import {BrowserRouter, Route,  Routes} from 'react-router-dom';

function App() {
  return (
      <BrowserRouter>
        <div className="container">
          <h3 className="m-3 d-flex justify-content-center">
            React JS Tutorial
          </h3>
          <Navigation/>
          <Routes>
            <Route path='/' element={<Home/>} exact/>
            <Route path='/department' element={<Department/>}/>
            <Route path='/employee' element={<Employee/>}/>
          </Routes>
        </div>
      </BrowserRouter>
  );
}

export default App;
