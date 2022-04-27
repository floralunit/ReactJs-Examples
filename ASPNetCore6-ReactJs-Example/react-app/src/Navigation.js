import React, {Component} from 'react'
import {NavLink} from 'react-router-dom';

import {Navbar, Nav, Container} from 'react-bootstrap';

export class Navigation extends Component{

    render() {
        return(
            <Navbar bg="dark" variant="dark">
                <Container>
                    <Navbar.Brand href="/">Home</Navbar.Brand>
                <Nav className="me-auto">
                    <Nav.Link href="/department">
                        Department
                    </Nav.Link>
                    <Nav.Link href="/employee">
                        Employee
                    </Nav.Link>
                </Nav>
                </Container>
            </Navbar>
        )
    }
}