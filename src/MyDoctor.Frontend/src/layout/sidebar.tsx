import * as React from "react";
import { Drawer } from "@mui/material";
import Box from "@mui/material/Box";

const drawerWidth = 240;
export default function Sidebar({ children }: React.PropsWithChildren) {
  return (
    <>
      <Drawer
        variant="permanent"
        sx={{
          width: drawerWidth,
          flexShrink: 0,
          [`& .MuiDrawer-paper`]: { width: drawerWidth, boxSizing: "border-box" },
        }}>
        <Box sx={{ overflow: "auto" }}>{children}</Box>
      </Drawer>
    </>
  );
}
