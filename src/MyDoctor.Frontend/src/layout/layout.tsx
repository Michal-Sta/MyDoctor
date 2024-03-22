import * as React from "react";
import Box from "@mui/material/Box";
import { Container, Grid } from "@mui/material";

export default function Layout({ children }: React.PropsWithChildren) {
  return (
    <Box
      sx={{
        minHeight: 1,
        display: "flex",
        flexDirection: { xs: "column", lg: "row" },
      }}>
      <Box
        component="main"
        sx={{
          flexGrow: 1,
          minHeight: 1,
          display: "flex",
          flexDirection: "column",
        }}>
        {children}
      </Box>
    </Box>
  );
}
