import { useState } from "react";
import NavBar from "./components/NavBar";
import SideMenu from "./components/SideNav";
import Navigation from "./routes/Navigation";
import "./styles/index.scss";

function App() {
	const [sideNavOpen, setSideNavOpen] = useState(false);

	function toggleSideNav() {
		setSideNavOpen((prev) => !prev);
	}

	return (
		<>
			<SideMenu sideNavOpen={sideNavOpen} onCloseClick={toggleSideNav} onSideNavBlur={toggleSideNav}/>
			<NavBar onMenuClick={toggleSideNav}/>
			<Navigation />
		</>
	);
}

export default App;