package VIA.VIATalks.Database.controllers;

import VIA.VIATalks.Database.jdbc.TicketHandler;
import VIA.VIATalks.Database.jdbc.handlerInterfaces.ITicketHandler;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/ticket")
public class TicketController {

    private ITicketHandler handler;

    public TicketController() {
    }

    //getTicketsForEvents
    //getTicketForEvent
    //getTicketsCountForEvents
    //getTicketsCountForEvent
    //issueTicketForEvent
    //removeTicketsForEvent
    //removeTicketForEvent

}
