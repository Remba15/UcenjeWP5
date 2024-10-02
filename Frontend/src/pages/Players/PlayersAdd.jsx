import { Button, Col, Form, Row } from "react-bootstrap";
import { Link, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";
import PlayerService from "../../services/PlayerService";
import moment from "moment";


export default function PlayersAdd(){
    const navigate = useNavigate()

    function obradiSubmit(e){
        e.preventDefault();
    }

    return(
        <>
        Add player
        <Form onSubmit={obradiSubmit}>

            <Form.Group controlId="username">
                <Form.Label>Username</Form.Label>
                <Form.Control type="text" name="username" required/>
            </Form.Group>

            <Form.Group controlId="registrationDate">
                <Form.Label>Registration Date</Form.Label>
                <Form.Control type="date" name="registrationDate"/>
            </Form.Group>

            <Form.Group controlId="region">
                <Form.Label>Region</Form.Label>
                <Form.Control type="text" name="region" required/>
            </Form.Group>

        <Row className="akcije">
            <Col xs={6} sm={12} md={3} lg={6} xl={6} xxl={6}>
                <Link to={RouteNames.PLAYERS_VIEW}
                className="btn btn-danger siroko">Cancel</Link>
            </Col>
            <Col xs={6} sm={12} md={9} lg={6} xl={6} xxl={6}>
                <Button variant="success"
                type="submit"
                className="siroko">Add player</Button>
            </Col>
        </Row>
        </Form>
        </>

    )
}