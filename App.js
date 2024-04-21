// import logo from "./logo.svg";
// import "./App.css";
// import Header from "./components/Header/Header";
// import Footer from "./components/Footer/Footer";
// import Content from "./components/Content/Content";
// import { Primary, Small } from "";
// import PrimaryButton from "./stories/Button.stories";
import Test from "./components/Test";
import Joueur from "./components/Joueur/Joueur";
import Login from "./components/Login";
import{BrowserRouter as Router,Route,Routes} from 'react-router-dom';
function App() {
  return (
      <Router>        
        <Routes>
            {sessionStorage.getItem("session") ? (
          <>
            <Route path="/test" element={<Test />} />
            <Route path="/joueur" element={<Joueur />} />
          </>
        ) : (
          <Route path="/*" element={<Login />} />
        )}
      </Routes>
          // <Route path="/test" element={<Test/>}></Route>
          // <Route path="/joueur" element={<Joueur/>}></Route>
      </Router>
      
  );
}

export default App;
