import { Box, Container, CssBaseline, List, ListItem, ListItemButton, ListItemIcon, ListItemText } from "@mui/material";
import { createRootRoute, Link, Outlet } from "@tanstack/react-router";
import { TanStackRouterDevtools } from "@tanstack/router-devtools";
import React from "react";
import BookmarkIcon from "@mui/icons-material/Bookmark";
import TroubleshootIcon from "@mui/icons-material/Troubleshoot";
import AccountBoxIcon from "@mui/icons-material/AccountBox";
import Layout from "../layout/layout";
import Sidebar from "../layout/sidebar";

export const Route = createRootRoute({
  component: () => (
    <>
      <CssBaseline />
      <Sidebar>
        <List>
          <Link to="/searcher">
            <ListItem disablePadding>
              <ListItemButton>
                <ListItemIcon>
                  <TroubleshootIcon />
                </ListItemIcon>
                <ListItemText primary={"Search doctor"} />
              </ListItemButton>
            </ListItem>
          </Link>
          <Link to="/appointment-list">
            <ListItem disablePadding>
              <ListItemButton>
                <ListItemIcon>
                  <BookmarkIcon />
                </ListItemIcon>
                <ListItemText primary={"Appointment"} />
              </ListItemButton>
            </ListItem>
          </Link>
          <Link to="/profile">
            <ListItem disablePadding>
              <ListItemButton>
                <ListItemIcon>
                  <AccountBoxIcon />
                </ListItemIcon>
                <ListItemText primary={"Profile"} />
              </ListItemButton>
            </ListItem>
          </Link>
        </List>
        <TanStackRouterDevtools />
      </Sidebar>
   
       <Layout>
       <Outlet />
     </Layout>
     </>
  ),
});
