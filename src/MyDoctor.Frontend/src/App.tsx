import "./App.css";
import Layout from "./layout/layout";
import { ThemeProvider } from "@mui/material/styles";
import { themeOptions } from "./utils/theme-options";
import React, { StrictMode } from "react";
import ReactDOM from "react-dom/client";
import { RouterProvider, createRouter, Outlet } from "@tanstack/react-router";
import { routeTree } from "./routeTree.gen";

const router = createRouter({ routeTree });

declare module "@tanstack/react-router" {
  interface Register {
    router: typeof router;
  }
}

function App() {
  return (
      <StrictMode>
          <RouterProvider router={router} />
      </StrictMode>
  );
}

export default App;
