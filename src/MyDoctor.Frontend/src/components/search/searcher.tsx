import * as React from "react";
import TextField from "@mui/material/TextField";
import Autocomplete from "@mui/material/Autocomplete";
import { Avatar, Box } from "@mui/material";
import AssignmentIcon from "@mui/icons-material/Assignment";
import { green} from '@mui/material/colors';

export const Searcher = () => {
  const options = top100Films.map((option) => {
    const specialization = option.specializationName;
    return {
      specialization,
      ...option,
    };
  });

  return (
    <Autocomplete
      id="grouped-demo"
      options={options.sort((a, b) => -b.specialization.localeCompare(a.specialization))}
      groupBy={(option) => option.specialization}
      getOptionLabel={(option) => option.fullName}
      sx={{ width: 300 }}
      renderOption={(props, option, { selected }) => (
        <li {...props}>
          <Avatar sx={{ bgcolor: green[500] }}>
            <AssignmentIcon />
          </Avatar>
          <Box
            component="span"
            sx={{
              width: 14,
              height: 14,
              flexShrink: 0,
              borderRadius: "3px",
              mr: 1,
              mt: "2px",
            }}
          />
          <Box>
            {option.fullName}
            <br />
            <span>{option.specialization}</span>
          </Box>
        </li>
      )}
      renderInput={(params) => <TextField {...params} label="With categories" />}
    />
    
    
  );
};
const top100Films = [
  { fullName: "dr Test 1", specializationName: "Pediatric" },
  { fullName: "dr Test 2", specializationName: "Pediatric" },
  { fullName: "dr Test 3", specializationName: "Pediatric" },
  { fullName: "dr Test 4", specializationName: "Cardio" },
  { fullName: "dr Test 5", specializationName: "Cardio" },
];
